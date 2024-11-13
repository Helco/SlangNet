using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IRHI.xml' path='doc/member[@name="IRHI"]/*' />
public unsafe partial struct IRHI
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const FormatInfo &")]
    public delegate FormatInfo* _getFormatInfo(IRHI* pThis, [NativeTypeName("rhi::Format")] Format format);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const char *")]
    public delegate sbyte* _getDeviceTypeName(IRHI* pThis, [NativeTypeName("rhi::DeviceType")] DeviceType type);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool _isDeviceTypeSupported(IRHI* pThis, [NativeTypeName("rhi::DeviceType")] DeviceType type);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getAdapters(IRHI* pThis, [NativeTypeName("rhi::DeviceType")] DeviceType type, ISlangBlob** outAdaptersBlob);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _createDevice(IRHI* pThis, [NativeTypeName("const DeviceDesc &")] DeviceDesc* desc, IDevice** outDevice);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _reportLiveObjects(IRHI* pThis);

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.getFormatInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const FormatInfo &")]
    public FormatInfo* getFormatInfo([NativeTypeName("rhi::Format")] Format format)
    {
        fixed (IRHI* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getFormatInfo>(lpVtbl->getFormatInfo)(pThis, format);
        }
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.getDeviceTypeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const char *")]
    public sbyte* getDeviceTypeName([NativeTypeName("rhi::DeviceType")] DeviceType type)
    {
        fixed (IRHI* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getDeviceTypeName>(lpVtbl->getDeviceTypeName)(pThis, type);
        }
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.isDeviceTypeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool isDeviceTypeSupported([NativeTypeName("rhi::DeviceType")] DeviceType type)
    {
        fixed (IRHI* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_isDeviceTypeSupported>(lpVtbl->isDeviceTypeSupported)(pThis, type);
        }
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.getAdapters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getAdapters([NativeTypeName("rhi::DeviceType")] DeviceType type, ISlangBlob** outAdaptersBlob)
    {
        fixed (IRHI* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getAdapters>(lpVtbl->getAdapters)(pThis, type, outAdaptersBlob);
        }
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.createDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int createDevice([NativeTypeName("const DeviceDesc &")] DeviceDesc* desc, IDevice** outDevice)
    {
        fixed (IRHI* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_createDevice>(lpVtbl->createDevice)(pThis, desc, outDevice);
        }
    }

    /// <include file='IRHI.xml' path='doc/member[@name="IRHI.reportLiveObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int reportLiveObjects()
    {
        fixed (IRHI* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_reportLiveObjects>(lpVtbl->reportLiveObjects)(pThis);
        }
    }

    public partial struct Vtbl
    {
        [NativeTypeName("const FormatInfo &(Format) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getFormatInfo;

        [NativeTypeName("const char *(DeviceType) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getDeviceTypeName;

        [NativeTypeName("bool (DeviceType) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr isDeviceTypeSupported;

        [NativeTypeName("Result (DeviceType, ISlangBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getAdapters;

        [NativeTypeName("Result (const DeviceDesc &, IDevice **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr createDevice;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr reportLiveObjects;
    }
}
