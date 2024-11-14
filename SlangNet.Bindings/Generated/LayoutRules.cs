using SlangNet.Unsafe;
using static SlangNet.Unsafe.SlangLayoutRules;

namespace SlangNet;

/// <include file='LayoutRules.xml' path='doc/member[@name="LayoutRules"]/*' />
[NativeTypeName("SlangLayoutRulesIntegral")]
public enum LayoutRules : uint
{
    /// <include file='LayoutRules.xml' path='doc/member[@name="LayoutRules.Default"]/*' />
    Default = SLANG_LAYOUT_RULES_DEFAULT,

    /// <include file='LayoutRules.xml' path='doc/member[@name="LayoutRules.MetalArgumentBufferTier2"]/*' />
    MetalArgumentBufferTier2 = SLANG_LAYOUT_RULES_METAL_ARGUMENT_BUFFER_TIER_2,
}
