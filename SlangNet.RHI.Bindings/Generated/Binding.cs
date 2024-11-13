using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

/// <include file='Binding.xml' path='doc/member[@name="Binding"]/*' />
public unsafe partial struct Binding
{
    /// <include file='Binding.xml' path='doc/member[@name="Binding.type"]/*' />
    [NativeTypeName("rhi::BindingType")]
    public BindingType type;

    /// <include file='Binding.xml' path='doc/member[@name="Binding.resource"]/*' />
    [NativeTypeName("ComPtr<IResource>")]
    public SlangNet.Unsafe.COMPointer<IResource> resource;

    /// <include file='Binding.xml' path='doc/member[@name="Binding.resource2"]/*' />
    [NativeTypeName("ComPtr<IResource>")]
    public SlangNet.Unsafe.COMPointer<IResource> resource2;

    /// <include file='Binding.xml' path='doc/member[@name="Binding.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_slang-rhi_L1099_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bufferRange"]/*' />
    public ref BufferRange bufferRange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (_Anonymous_e__Union* pField = &Anonymous)
            {
                return ref pField->bufferRange;
            }
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.bufferRange"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("rhi::BufferRange")]
        public BufferRange bufferRange;
    }
}
