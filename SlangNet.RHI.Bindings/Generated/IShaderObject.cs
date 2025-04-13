using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject"]/*' />
[NativeTypeName("struct IShaderObject : ISlangUnknown")]
public unsafe partial struct IShaderObject
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((IShaderObject*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getElementTypeLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::TypeLayoutReflection *")]
    public TypeLayoutReflection* getElementTypeLayout()
    {
        return lpVtbl->getElementTypeLayout((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getContainerType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::ShaderObjectContainerType")]
    public ShaderObjectContainerType getContainerType()
    {
        return lpVtbl->getContainerType((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getEntryPointCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint getEntryPointCount()
    {
        return lpVtbl->getEntryPointCount((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getEntryPoint([NativeTypeName("uint32_t")] uint index, IShaderObject** outEntryPoint)
    {
        return lpVtbl->getEntryPoint((IShaderObject*)Unsafe.AsPointer(ref this), index, outEntryPoint);
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setData([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("const void *")] void* data, [NativeTypeName("rhi::Size")] ulong size)
    {
        return lpVtbl->setData((IShaderObject*)Unsafe.AsPointer(ref this), offset, data, size);
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getObject([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, IShaderObject** outObject)
    {
        return lpVtbl->getObject((IShaderObject*)Unsafe.AsPointer(ref this), offset, outObject);
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setObject([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("rhi::IShaderObject *")] IShaderObject* @object)
    {
        return lpVtbl->setObject((IShaderObject*)Unsafe.AsPointer(ref this), offset, @object);
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setBinding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setBinding([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("const Binding &")] Binding* binding)
    {
        return lpVtbl->setBinding((IShaderObject*)Unsafe.AsPointer(ref this), offset, binding);
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setSpecializationArgs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setSpecializationArgs([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("const slang::SpecializationArg *")] SpecializationArg* args, [NativeTypeName("uint32_t")] uint count)
    {
        return lpVtbl->setSpecializationArgs((IShaderObject*)Unsafe.AsPointer(ref this), offset, args, count);
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getRawData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const void *")]
    public void* getRawData()
    {
        return lpVtbl->getRawData((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Size")]
    public ulong getSize()
    {
        return lpVtbl->getSize((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setConstantBufferOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setConstantBufferOverride([NativeTypeName("rhi::IBuffer *")] IBuffer* constantBuffer)
    {
        return lpVtbl->setConstantBufferOverride((IShaderObject*)Unsafe.AsPointer(ref this), constantBuffer);
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.finalize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int finalize()
    {
        return lpVtbl->finalize((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.isFinalized"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool isFinalized()
    {
        return lpVtbl->isFinalized((IShaderObject*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, uint> release;

        [NativeTypeName("slang::TypeLayoutReflection *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, TypeLayoutReflection*> getElementTypeLayout;

        [NativeTypeName("ShaderObjectContainerType () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, ShaderObjectContainerType> getContainerType;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, uint> getEntryPointCount;

        [NativeTypeName("Result (uint32_t, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, uint, IShaderObject**, int> getEntryPoint;

        [NativeTypeName("Result (const ShaderOffset &, const void *, Size) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, ShaderOffset*, void*, ulong, int> setData;

        [NativeTypeName("Result (const ShaderOffset &, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, ShaderOffset*, IShaderObject**, int> getObject;

        [NativeTypeName("Result (const ShaderOffset &, IShaderObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, ShaderOffset*, IShaderObject*, int> setObject;

        [NativeTypeName("Result (const ShaderOffset &, const Binding &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, ShaderOffset*, Binding*, int> setBinding;

        [NativeTypeName("Result (const ShaderOffset &, const slang::SpecializationArg *, uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, ShaderOffset*, SpecializationArg*, uint, int> setSpecializationArgs;

        [NativeTypeName("const void *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, void*> getRawData;

        [NativeTypeName("Size () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, ulong> getSize;

        [NativeTypeName("Result (IBuffer *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, IBuffer*, int> setConstantBufferOverride;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, int> finalize;

        [NativeTypeName("bool () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IShaderObject*, bool> isFinalized;
    }
}
