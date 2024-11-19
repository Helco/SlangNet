using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IShaderTable.xml' path='doc/member[@name="IShaderTable"]/*' />
[NativeTypeName("struct IShaderTable : ISlangUnknown")]
public unsafe partial struct IShaderTable
{
    public Vtbl* lpVtbl;

    /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite"]/*' />
    public partial struct ShaderRecordOverwrite
    {
        /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.offset"]/*' />
        [NativeTypeName("rhi::Offset")]
        public ulong offset;

        /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.size"]/*' />
        [NativeTypeName("rhi::Size")]
        public ulong size;

        /// <include file='ShaderRecordOverwrite.xml' path='doc/member[@name="ShaderRecordOverwrite.data"]/*' />
        [NativeTypeName("uint8_t[8]")]
        public _data_e__FixedBuffer data;

        /// <include file='_data_e__FixedBuffer.xml' path='doc/member[@name="_data_e__FixedBuffer"]/*' />
        [InlineArray(8)]
        public partial struct _data_e__FixedBuffer
        {
            public byte e0;
        }
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
        return lpVtbl->queryInterface((IShaderTable*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IShaderTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IShaderTable*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderTable*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderTable*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderTable*, uint> release;
    }
}
