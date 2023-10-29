using static SlangNet.SlangLayoutRules;

namespace SlangNet;

/// <include file='LayoutRules.xml' path='doc/member[@name="LayoutRules"]/*' />
[NativeTypeName("SlangLayoutRulesIntegral")]
public enum LayoutRules : uint
{
    /// <include file='LayoutRules.xml' path='doc/member[@name="LayoutRules.Default"]/*' />
    Default = SLANG_LAYOUT_RULES_DEFAULT,
}
