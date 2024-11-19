using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IShaderTable.xml' path='doc/member[@name="IShaderTable"]/*' />
[NativeTypeName("struct IShaderTable : ISlangUnknown")]
public unsafe partial struct IShaderTable
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IShaderTable* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IShaderTable* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IShaderTable* pThis);

    /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite"]/*' />
    public unsafe partial struct ShaderRecordOverwrite
    {
        /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.offset"]/*' />
        [NativeTypeName("rhi::Offset")]
        public ulong offset;

        /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.size"]/*' />
        [NativeTypeName("rhi::Size")]
        public ulong size;

        /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.data"]/*' />
        [NativeTypeName("uint8_t[8]")]
        public fixed byte data[8];
    }

    /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc"]/*' />
    public unsafe partial struct IShaderTable_Desc
    {
        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.rayGenShaderCount"]/*' />
        [NativeTypeName("rhi::GfxCount")]
        public int rayGenShaderCount;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.rayGenShaderEntryPointNames"]/*' />
        [NativeTypeName("const char **")]
        public sbyte** rayGenShaderEntryPointNames;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.rayGenShaderRecordOverwrites"]/*' />
        [NativeTypeName("const ShaderRecordOverwrite *")]
        public ShaderRecordOverwrite* rayGenShaderRecordOverwrites;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.missShaderCount"]/*' />
        [NativeTypeName("rhi::GfxCount")]
        public int missShaderCount;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.missShaderEntryPointNames"]/*' />
        [NativeTypeName("const char **")]
        public sbyte** missShaderEntryPointNames;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.missShaderRecordOverwrites"]/*' />
        [NativeTypeName("const ShaderRecordOverwrite *")]
        public ShaderRecordOverwrite* missShaderRecordOverwrites;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.hitGroupCount"]/*' />
        [NativeTypeName("rhi::GfxCount")]
        public int hitGroupCount;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.hitGroupNames"]/*' />
        [NativeTypeName("const char **")]
        public sbyte** hitGroupNames;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.hitGroupRecordOverwrites"]/*' />
        [NativeTypeName("const ShaderRecordOverwrite *")]
        public ShaderRecordOverwrite* hitGroupRecordOverwrites;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.callableShaderCount"]/*' />
        [NativeTypeName("rhi::GfxCount")]
        public int callableShaderCount;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.callableShaderEntryPointNames"]/*' />
        [NativeTypeName("const char **")]
        public sbyte** callableShaderEntryPointNames;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.callableShaderRecordOverwrites"]/*' />
        [NativeTypeName("const ShaderRecordOverwrite *")]
        public ShaderRecordOverwrite* callableShaderRecordOverwrites;

        /// <include file='IShaderTable_Desc.xml' path='doc/member[@name="IShaderTable_Desc.program"]/*' />
        [NativeTypeName("rhi::IShaderProgram *")]
        public IShaderProgram* program;
    }

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IShaderTable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IShaderTable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IShaderTable* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr release;
    }
}
