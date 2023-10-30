using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangStage.xml' path='doc/member[@name="SlangStage"]/*' />
[NativeTypeName("SlangStageIntegral")]
public enum SlangStage : uint
{
    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_NONE"]/*' />
    SLANG_STAGE_NONE,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_VERTEX"]/*' />
    SLANG_STAGE_VERTEX,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_HULL"]/*' />
    SLANG_STAGE_HULL,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_DOMAIN"]/*' />
    SLANG_STAGE_DOMAIN,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_GEOMETRY"]/*' />
    SLANG_STAGE_GEOMETRY,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_FRAGMENT"]/*' />
    SLANG_STAGE_FRAGMENT,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_COMPUTE"]/*' />
    SLANG_STAGE_COMPUTE,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_RAY_GENERATION"]/*' />
    SLANG_STAGE_RAY_GENERATION,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_INTERSECTION"]/*' />
    SLANG_STAGE_INTERSECTION,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_ANY_HIT"]/*' />
    SLANG_STAGE_ANY_HIT,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_CLOSEST_HIT"]/*' />
    SLANG_STAGE_CLOSEST_HIT,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_MISS"]/*' />
    SLANG_STAGE_MISS,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_CALLABLE"]/*' />
    SLANG_STAGE_CALLABLE,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_MESH"]/*' />
    SLANG_STAGE_MESH,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_AMPLIFICATION"]/*' />
    SLANG_STAGE_AMPLIFICATION,

    /// <include file='SlangStage.xml' path='doc/member[@name="SlangStage.SLANG_STAGE_PIXEL"]/*' />
    SLANG_STAGE_PIXEL = SLANG_STAGE_FRAGMENT,
}
