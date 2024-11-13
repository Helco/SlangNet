namespace SlangNet.RHI.Unsafe;

/// <include file='AdapterList.xml' path='doc/member[@name="AdapterList"]/*' />
public partial struct AdapterList
{
    /// <include file='AdapterList.xml' path='doc/member[@name="AdapterList.m_blob"]/*' />
    [NativeTypeName("ComPtr<ISlangBlob>")]
    private SlangNet.Unsafe.COMPointer<ISlangBlob> m_blob;
}
