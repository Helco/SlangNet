using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='ISurface.xml' path='doc/member[@name="ISurface"]/*' />
[NativeTypeName("struct ISurface : ISlangUnknown")]
public unsafe partial struct ISurface
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(ISurface* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(ISurface* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(ISurface* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const SurfaceInfo &")]
    public delegate SurfaceInfo* _getInfo(ISurface* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const SurfaceConfig &")]
    public delegate SurfaceConfig* _getConfig(ISurface* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _configure(ISurface* pThis, [NativeTypeName("const SurfaceConfig &")] SurfaceConfig* config);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getCurrentTexture(ISurface* pThis, ITexture** outTexture);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _present(ISurface* pThis);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.getInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const SurfaceInfo &")]
    public SurfaceInfo* getInfo()
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getInfo>(lpVtbl->getInfo)(pThis);
        }
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.getConfig"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const SurfaceConfig &")]
    public SurfaceConfig* getConfig()
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getConfig>(lpVtbl->getConfig)(pThis);
        }
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.configure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int configure([NativeTypeName("const SurfaceConfig &")] SurfaceConfig* config)
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_configure>(lpVtbl->configure)(pThis, config);
        }
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.getCurrentTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getCurrentTexture(ITexture** outTexture)
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getCurrentTexture>(lpVtbl->getCurrentTexture)(pThis, outTexture);
        }
    }

    /// <include file='ISurface.xml' path='doc/member[@name="ISurface.present"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int present()
    {
        fixed (ISurface* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_present>(lpVtbl->present)(pThis);
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

        [NativeTypeName("const SurfaceInfo &() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getInfo;

        [NativeTypeName("const SurfaceConfig &() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getConfig;

        [NativeTypeName("Result (const SurfaceConfig &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr configure;

        [NativeTypeName("Result (ITexture **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getCurrentTexture;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr present;
    }
}
