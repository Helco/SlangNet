using SlangNet.Unsafe;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject"]/*' />
[NativeTypeName("struct IShaderObject : ISlangUnknown")]
public unsafe partial struct IShaderObject
{
    public Vtbl* lpVtbl;

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("SlangResult")]
    public delegate int _queryInterface(IShaderObject* pThis, [NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _addRef(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("uint32_t")]
    public delegate uint _release(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("slang::TypeLayoutReflection *")]
    public delegate TypeLayoutReflection* _getElementTypeLayout(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::ShaderObjectContainerType")]
    public delegate ShaderObjectContainerType _getContainerType(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::GfxCount")]
    public delegate int _getEntryPointCount(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getEntryPoint(IShaderObject* pThis, [NativeTypeName("rhi::GfxIndex")] int index, IShaderObject** entryPoint);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _setData(IShaderObject* pThis, [NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("const void *")] void* data, [NativeTypeName("rhi::Size")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _getObject(IShaderObject* pThis, [NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, IShaderObject** @object);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _setObject(IShaderObject* pThis, [NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("rhi::IShaderObject *")] IShaderObject* @object);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _setBinding(IShaderObject* pThis, [NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("rhi::Binding")] Binding binding);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _setSpecializationArgs(IShaderObject* pThis, [NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("const slang::SpecializationArg *")] SpecializationArg* args, [NativeTypeName("rhi::GfxCount")] int count);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("const void *")]
    public delegate void* _getRawData(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Size")]
    public delegate UIntPtr _getSize(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _setConstantBufferOverride(IShaderObject* pThis, [NativeTypeName("rhi::IBuffer *")] IBuffer* constantBuffer);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("rhi::Result")]
    public delegate int _finalize(IShaderObject* pThis);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate bool _isFinalized(IShaderObject* pThis);

    /// <inheritdoc cref="ISlangUnknown.queryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("SlangResult")]
    public int queryInterface([NativeTypeName("const SlangUUID &")] SlangUUID* uuid, void** outObject)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_queryInterface>(lpVtbl->queryInterface)(pThis, uuid, outObject);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.addRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint addRef()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_addRef>(lpVtbl->addRef)(pThis);
        }
    }

    /// <inheritdoc cref="ISlangUnknown.release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("uint32_t")]
    public uint release()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_release>(lpVtbl->release)(pThis);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getElementTypeLayout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("slang::TypeLayoutReflection *")]
    public TypeLayoutReflection* getElementTypeLayout()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getElementTypeLayout>(lpVtbl->getElementTypeLayout)(pThis);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getContainerType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::ShaderObjectContainerType")]
    public ShaderObjectContainerType getContainerType()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getContainerType>(lpVtbl->getContainerType)(pThis);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getEntryPointCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::GfxCount")]
    public int getEntryPointCount()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPointCount>(lpVtbl->getEntryPointCount)(pThis);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getEntryPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getEntryPoint([NativeTypeName("rhi::GfxIndex")] int index, IShaderObject** entryPoint)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getEntryPoint>(lpVtbl->getEntryPoint)(pThis, index, entryPoint);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setData([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("const void *")] void* data, [NativeTypeName("rhi::Size")] UIntPtr size)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setData>(lpVtbl->setData)(pThis, offset, data, size);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int getObject([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, IShaderObject** @object)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getObject>(lpVtbl->getObject)(pThis, offset, @object);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setObject([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("rhi::IShaderObject *")] IShaderObject* @object)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setObject>(lpVtbl->setObject)(pThis, offset, @object);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setBinding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setBinding([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("rhi::Binding")] Binding binding)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setBinding>(lpVtbl->setBinding)(pThis, offset, binding);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setSpecializationArgs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setSpecializationArgs([NativeTypeName("const ShaderOffset &")] ShaderOffset* offset, [NativeTypeName("const slang::SpecializationArg *")] SpecializationArg* args, [NativeTypeName("rhi::GfxCount")] int count)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setSpecializationArgs>(lpVtbl->setSpecializationArgs)(pThis, offset, args, count);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getRawData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("const void *")]
    public void* getRawData()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getRawData>(lpVtbl->getRawData)(pThis);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.getSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Size")]
    public UIntPtr getSize()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_getSize>(lpVtbl->getSize)(pThis);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.setConstantBufferOverride"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int setConstantBufferOverride([NativeTypeName("rhi::IBuffer *")] IBuffer* constantBuffer)
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_setConstantBufferOverride>(lpVtbl->setConstantBufferOverride)(pThis, constantBuffer);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.finalize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("rhi::Result")]
    public int finalize()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_finalize>(lpVtbl->finalize)(pThis);
        }
    }

    /// <include file='IShaderObject.xml' path='doc/member[@name="IShaderObject.isFinalized"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool isFinalized()
    {
        fixed (IShaderObject* pThis = &this)
        {
            return Marshal.GetDelegateForFunctionPointer<_isFinalized>(lpVtbl->isFinalized)(pThis);
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

        [NativeTypeName("slang::TypeLayoutReflection *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getElementTypeLayout;

        [NativeTypeName("ShaderObjectContainerType () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getContainerType;

        [NativeTypeName("GfxCount () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPointCount;

        [NativeTypeName("Result (GfxIndex, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getEntryPoint;

        [NativeTypeName("Result (const ShaderOffset &, const void *, Size) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setData;

        [NativeTypeName("Result (const ShaderOffset &, IShaderObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getObject;

        [NativeTypeName("Result (const ShaderOffset &, IShaderObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setObject;

        [NativeTypeName("Result (const ShaderOffset &, Binding) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setBinding;

        [NativeTypeName("Result (const ShaderOffset &, const slang::SpecializationArg *, GfxCount) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setSpecializationArgs;

        [NativeTypeName("const void *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getRawData;

        [NativeTypeName("Size () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr getSize;

        [NativeTypeName("Result (IBuffer *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr setConstantBufferOverride;

        [NativeTypeName("Result () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr finalize;

        [NativeTypeName("bool () __attribute__((nothrow)) __attribute__((stdcall))")]
        public IntPtr isFinalized;
    }
}
