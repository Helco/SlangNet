using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SlangNet.Unsafe;

namespace SlangNet;

internal unsafe struct NativeSessionDescription : IDisposable
{
    public SessionDesc Native;
    public Utf8String[] Strings;

    public void Dispose()
    {
        Marshal.FreeCoTaskMem(new(Native.targets));
        Marshal.FreeCoTaskMem(new(Native.searchPaths));
        Marshal.FreeCoTaskMem(new(Native.preprocessorMacros));
        foreach (var str in Strings)
            str.Dispose();
    }
}

public unsafe sealed class SessionDescription
{
    public IList<TargetDescription> Targets { get; } = new List<TargetDescription>();
    public SessionFlags Flags { get; set; }
    public MatrixLayoutMode DefaultMatrixLayoutMode { get; set; } = MatrixLayoutMode.RowMajor;
    public IList<string> SearchPaths { get; } = new List<string>();
    public IDictionary<string, string> PreprocessorMacros { get; } = new Dictionary<string, string>();
    //public ISlangFileSystem? FileSystem { get; set; }
    public bool EnableEffectAnnotations { get; set; }

    internal unsafe NativeSessionDescription AsNative()
    {
        var desc = new NativeSessionDescription()
        {
            Native = new()
            {
                structureSize = new((uint)sizeof(SessionDesc)),
                targetCount = Targets.Count,
                flags = (uint)Flags,
                defaultMatrixLayoutMode = (SlangMatrixLayoutMode)DefaultMatrixLayoutMode,
                searchPathCount = SearchPaths.Count,
                preprocessorMacroCount = PreprocessorMacros.Count,
                fileSystem = null,
                enableEffectAnnotations = EnableEffectAnnotations ? (byte)1 : (byte)0
            },
            Strings = new Utf8String[SearchPaths.Count + 2 * PreprocessorMacros.Count]
        };

        var targets = (TargetDesc*)Marshal.AllocCoTaskMem(sizeof(TargetDesc) * Targets.Count);
        var curTarget = targets;
        foreach (var target in Targets)
            target.AsNative(curTarget++);
        desc.Native.targets = targets;

        var stringI = 0;
        var searchPathPtrs = (sbyte**)Marshal.AllocCoTaskMem(sizeof(void*) * SearchPaths.Count);
        var curSearchPathPtr = searchPathPtrs;
        foreach (var path in SearchPaths)
            *curSearchPathPtr++ = desc.Strings[stringI++] = new(path);
        desc.Native.searchPaths = searchPathPtrs;

        var macros = (PreprocessorMacroDesc*)Marshal.AllocCoTaskMem(sizeof(PreprocessorMacroDesc) * PreprocessorMacros.Count);
        var curMacro = macros;
        foreach (var (name, value) in PreprocessorMacros)
        {
            curMacro->name = desc.Strings[stringI++] = new(name);
            curMacro->value = desc.Strings[stringI++] = new(value);
            curMacro++;
        }
        desc.Native.preprocessorMacros = macros;

        return desc;
    }
}