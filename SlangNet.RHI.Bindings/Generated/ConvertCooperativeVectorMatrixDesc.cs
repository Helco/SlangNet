namespace SlangNet.RHI.Unsafe;

/// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc"]/*' />
public unsafe partial struct ConvertCooperativeVectorMatrixDesc
{
    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.srcSize"]/*' />
    [NativeTypeName("size_t")]
    public nuint srcSize;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.srcData"]/*' />
    [NativeTypeName("rhi::DeviceOrHostAddressConst")]
    public DeviceOrHostAddressConst srcData;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.dstSize"]/*' />
    [NativeTypeName("size_t *")]
    public nuint* dstSize;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.dstData"]/*' />
    [NativeTypeName("rhi::DeviceOrHostAddress")]
    public DeviceOrHostAddress dstData;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.srcComponentType"]/*' />
    [NativeTypeName("rhi::CooperativeVectorComponentType")]
    public CooperativeVectorComponentType srcComponentType;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.dstComponentType"]/*' />
    [NativeTypeName("rhi::CooperativeVectorComponentType")]
    public CooperativeVectorComponentType dstComponentType;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.rowCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint rowCount;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.colCount"]/*' />
    [NativeTypeName("uint32_t")]
    public uint colCount;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.srcLayout"]/*' />
    [NativeTypeName("rhi::CooperativeVectorMatrixLayout")]
    public CooperativeVectorMatrixLayout srcLayout;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.srcStride"]/*' />
    [NativeTypeName("size_t")]
    public nuint srcStride;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.dstLayout"]/*' />
    [NativeTypeName("rhi::CooperativeVectorMatrixLayout")]
    public CooperativeVectorMatrixLayout dstLayout;

    /// <include file='ConvertCooperativeVectorMatrixDesc.xml' path='doc/member[@name="ConvertCooperativeVectorMatrixDesc.dstStride"]/*' />
    [NativeTypeName("size_t")]
    public nuint dstStride;
}
