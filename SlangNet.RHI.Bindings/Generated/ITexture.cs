using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ITexture.xml' path='doc/member[@name="ITexture"]/*' />
[NativeTypeName("struct ITexture : rhi::IResource")]
public unsafe partial struct ITexture
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((ITexture*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((ITexture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((ITexture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IResource.getNativeHandle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getNativeHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getNativeHandle((ITexture*)Unsafe.AsPointer(ref this), outHandle);
    }

    /// <include file='ITexture.xml' path='doc/member[@name="ITexture.getDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const TextureDesc &")]
    public TextureDesc* getDesc()
    {
        return lpVtbl->getDesc((ITexture*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITexture.xml' path='doc/member[@name="ITexture.getSharedHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getSharedHandle([NativeTypeName("rhi::NativeHandle *")] NativeHandle* outHandle)
    {
        return lpVtbl->getSharedHandle((ITexture*)Unsafe.AsPointer(ref this), outHandle);
    }

    /// <include file='ITexture.xml' path='doc/member[@name="ITexture.createView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createView([NativeTypeName("const TextureViewDesc &")] TextureViewDesc* desc, ITextureView** outTextureView)
    {
        return lpVtbl->createView((ITexture*)Unsafe.AsPointer(ref this), desc, outTextureView);
    }

    /// <include file='ITexture.xml' path='doc/member[@name="ITexture.getSubresourceLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getSubresourceLayout([NativeTypeName("uint32_t")] uint mipLevel, [NativeTypeName("size_t")] nuint rowAlignment, [NativeTypeName("rhi::SubresourceLayout *")] SubresourceLayout* outLayout)
    {
        return lpVtbl->getSubresourceLayout((ITexture*)Unsafe.AsPointer(ref this), mipLevel, rowAlignment, outLayout);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, uint> release;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, NativeHandle*, int> getNativeHandle;

        [NativeTypeName("const TextureDesc &() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, TextureDesc*> getDesc;

        [NativeTypeName("Result (NativeHandle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, NativeHandle*, int> getSharedHandle;

        [NativeTypeName("Result (const TextureViewDesc &, ITextureView **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, TextureViewDesc*, ITextureView**, int> createView;

        [NativeTypeName("Result (uint32_t, size_t, SubresourceLayout *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ITexture*, uint, nuint, SubresourceLayout*, int> getSubresourceLayout;
    }
}
