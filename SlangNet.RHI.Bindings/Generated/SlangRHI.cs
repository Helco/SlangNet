using System.Runtime.InteropServices;

namespace SlangNet.RHI.Unsafe;

public static unsafe partial class SlangRHI
{
    [NativeTypeName("const uint64_t")]
    public const ulong kTimeoutInfinite = 0xFFFFFFFFFFFFFFFF;

    [NativeTypeName("const BufferRange")]
    public static readonly BufferRange kEntireBuffer = (BufferRange)(new BufferRange
    {
        offset = 0UL,
        size = unchecked(~0UL),
    });

    [NativeTypeName("const SubresourceRange")]
    public static readonly SubresourceRange kEntireTexture = (SubresourceRange)(new SubresourceRange
    {
        mipLevel = 0,
        mipLevelCount = 0x7fffffff,
        baseArrayLayer = 0,
        layerCount = 0x7fffffff,
    });

    public const int EnableNone = 0;
    public const int EnableRed = 0x01;
    public const int EnableGreen = 0x02;
    public const int EnableBlue = 0x04;
    public const int EnableAlpha = 0x08;
    public const int EnableAll = 0x0F;

    /// <include file='SlangRHI.xml' path='doc/member[@name="SlangRHI.getRHI"]/*' />
    [DllImport("slang-rhi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
    [return: NativeTypeName("rhi::IRHI *")]
    public static extern IRHI* getRHI();
}
