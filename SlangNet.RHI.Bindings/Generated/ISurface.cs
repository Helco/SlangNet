using SlangNet.Unsafe;
using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ISurface.xml' path='doc/member[@name="ISurface"]/*' />
[NativeTypeName("struct ISurface : ISlangUnknown")]
public unsafe partial struct ISurface
{
    public Vtbl* lpVtbl;

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        return lpVtbl->queryInterface((ISurface*)Unsafe.AsPointer(ref this), uuid, outObject);
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        return lpVtbl->addRef((ISurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        return lpVtbl->release((ISurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.getInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const SurfaceInfo &")]
    public SurfaceInfo* getInfo()
    {
        return lpVtbl->getInfo((ISurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.getConfig"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const SurfaceConfig &")]
    public SurfaceConfig* getConfig()
    {
        return lpVtbl->getConfig((ISurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.configure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int configure([NativeTypeName("const SurfaceConfig &")] SurfaceConfig* config)
    {
        return lpVtbl->configure((ISurface*)Unsafe.AsPointer(ref this), config);
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.acquireNextImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int acquireNextImage(ITexture** outTexture)
    {
        return lpVtbl->acquireNextImage((ISurface*)Unsafe.AsPointer(ref this), outTexture);
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.present"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int present()
    {
        return lpVtbl->present((ISurface*)Unsafe.AsPointer(ref this));
    }

    public partial struct Vtbl
    {
        [NativeTypeName("SlangResult (const SlangUUID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, SlangUUID*, void**, int> queryInterface;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, uint> addRef;

        [NativeTypeName("uint32_t () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, uint> release;

        [NativeTypeName("const SurfaceInfo &() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, SurfaceInfo*> getInfo;

        [NativeTypeName("const SurfaceConfig &() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, SurfaceConfig*> getConfig;

        [NativeTypeName("Result (const SurfaceConfig &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, SurfaceConfig*, int> configure;

        [NativeTypeName("Result (ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, ITexture**, int> acquireNextImage;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<ISurface*, int> present;
    }
}
