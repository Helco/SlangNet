using static SlangNet.Unsafe.SlangStage;

namespace SlangNet;

public enum Stage : uint
{
    None = SLANG_STAGE_NONE,
    Vertex = SLANG_STAGE_VERTEX,
    Hull = SLANG_STAGE_HULL,
    Domain = SLANG_STAGE_DOMAIN,
    Geometry = SLANG_STAGE_GEOMETRY,
    Fragment = SLANG_STAGE_FRAGMENT,
    Compute = SLANG_STAGE_COMPUTE,
    RayGeneration = SLANG_STAGE_RAY_GENERATION,
    Intersection = SLANG_STAGE_INTERSECTION,
    AnyHit = SLANG_STAGE_ANY_HIT,
    ClosestHit = SLANG_STAGE_CLOSEST_HIT,
    Miss = SLANG_STAGE_MISS,
    Callable = SLANG_STAGE_CALLABLE,
    Mesh = SLANG_STAGE_MESH,
    Amplification = SLANG_STAGE_AMPLIFICATION,
    Pixel = SLANG_STAGE_PIXEL,
}
