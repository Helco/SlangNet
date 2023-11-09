using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SlangNet;

internal unsafe struct Utf8String : IDisposable
{
    public static implicit operator sbyte*(Utf8String self) => self.Memory;

#if NETSTANDARD2_1_OR_GREATER
    public sbyte* Memory { get; private set; }
    public sbyte* MemoryEnd { get; private set; }

    public Utf8String(string? text)
    {
        Memory = (sbyte*)Marshal.StringToCoTaskMemUTF8(text);
        MemoryEnd = Memory + InteropUtils.StrLen(Memory);
    }

    public void Dispose()
    {
        if (Memory != null)
        {
            Marshal.FreeCoTaskMem(new(Memory));
            Memory = MemoryEnd = null;
        }
    }

#else
    private GCHandle handle;
    public sbyte* Memory => handle == default
        ? null
        : (sbyte*)handle.AddrOfPinnedObject();
    public sbyte* MemoryEnd { get; }

    public Utf8String(string? text)
    {
        handle = default;
        if (text == null)
            return;
        var bytes = System.Text.Encoding.UTF8.GetBytes(text);
        handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
        MemoryEnd = Memory + bytes.Length;
    }

    public void Dispose()
    {
        if (handle != default)
        {
            handle.Free();
            handle = default;
        }
    }
#endif
}

internal unsafe struct Utf8StringArray : IDisposable
{
    public sbyte** Memory { get; private set; }
    public int Count { get; private set; }
    private Utf8String[] strings;

    public Utf8StringArray(IEnumerable<string> managedStrings)
    {
        Count = managedStrings.Count();
        strings = new Utf8String[Count];
        try
        {
            Memory = (sbyte**)Marshal.AllocCoTaskMem(sizeof(sbyte*) * Count);
            int i = 0;
            foreach (var str in managedStrings)
            {
                strings[i] = new Utf8String(str);
                Memory[i] = strings[i];
                i++;
            }
        }
        finally
        {
            Dispose();
        }
    }

    public void Dispose()
    {
        if (Memory != null)
        {
            Marshal.FreeCoTaskMem(new(Memory));
            Memory = null;
        }
        foreach (var str in strings)
            str.Dispose();
    }
}
