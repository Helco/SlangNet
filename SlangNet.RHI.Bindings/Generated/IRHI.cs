using System.Runtime.CompilerServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IRHI.xml' path='doc/member[@name="IRHI"]/*' />
public unsafe partial struct IRHI
{
    public Vtbl* lpVtbl;

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.getFormatInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const FormatInfo &")]
    public FormatInfo* getFormatInfo([NativeTypeName("rhi::Format")] Format format)
    {
        return lpVtbl->getFormatInfo((IRHI*)Unsafe.AsPointer(ref this), format);
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.getDeviceTypeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getDeviceTypeName([NativeTypeName("rhi::DeviceType")] DeviceType type)
    {
        return lpVtbl->getDeviceTypeName((IRHI*)Unsafe.AsPointer(ref this), type);
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.isDeviceTypeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool isDeviceTypeSupported([NativeTypeName("rhi::DeviceType")] DeviceType type)
    {
        return lpVtbl->isDeviceTypeSupported((IRHI*)Unsafe.AsPointer(ref this), type);
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.getAdapters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getAdapters([NativeTypeName("rhi::DeviceType")] DeviceType type, [NativeTypeName("ISlangBlob **")] SlangNet.Unsafe.ISlangBlob** outAdaptersBlob)
    {
        return lpVtbl->getAdapters((IRHI*)Unsafe.AsPointer(ref this), type, outAdaptersBlob);
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.enableDebugLayers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void enableDebugLayers()
    {
        lpVtbl->enableDebugLayers((IRHI*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.createDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createDevice([NativeTypeName("const DeviceDesc &")] DeviceDesc* desc, IDevice** outDevice)
    {
        return lpVtbl->createDevice((IRHI*)Unsafe.AsPointer(ref this), desc, outDevice);
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.reportLiveObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int reportLiveObjects()
    {
        return lpVtbl->reportLiveObjects((IRHI*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.setTaskPoolWorkerCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setTaskPoolWorkerCount([NativeTypeName("uint32_t")] uint count)
    {
        return lpVtbl->setTaskPoolWorkerCount((IRHI*)Unsafe.AsPointer(ref this), count);
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.setTaskScheduler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setTaskScheduler([NativeTypeName("rhi::ITaskScheduler *")] ITaskScheduler* scheduler)
    {
        return lpVtbl->setTaskScheduler((IRHI*)Unsafe.AsPointer(ref this), scheduler);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("const FormatInfo &(Format) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, Format, FormatInfo*> getFormatInfo;

        [NativeTypeName("const char *(DeviceType) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, DeviceType, sbyte*> getDeviceTypeName;

        [NativeTypeName("bool (DeviceType) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, DeviceType, bool> isDeviceTypeSupported;

        [NativeTypeName("Result (DeviceType, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, DeviceType, SlangNet.Unsafe.ISlangBlob**, int> getAdapters;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, void> enableDebugLayers;

        [NativeTypeName("Result (const DeviceDesc &, IDevice **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, DeviceDesc*, IDevice**, int> createDevice;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, int> reportLiveObjects;

        [NativeTypeName("Result (uint32_t) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, uint, int> setTaskPoolWorkerCount;

        [NativeTypeName("Result (ITaskScheduler *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[Stdcall]<IRHI*, ITaskScheduler*, int> setTaskScheduler;
    }
}
