using SlangNet.Unsafe;

namespace SlangNet;

public struct TargetDescription
{
    private TargetDesc native;

    public CompileTarget Format
    {
        get => (CompileTarget)native.format;
        set => native.format = (SlangCompileTarget)value;
    }

    public ProfileID Profile
    {
        get => (ProfileID)native.profile;
        set => native.profile = (SlangProfileID)value;
    }

    public TargetFlags Flags
    {
        get => (TargetFlags)native.flags;
        set => native.flags = (uint)value;
    }

    public FloatingPointMode FloatingPointMode
    {
        get => (FloatingPointMode)native.floatingPointMode;
        set => native.floatingPointMode = (SlangFloatingPointMode)value;
    }

    public LineDirectiveMode LineDirectiveMode
    {
        get => (LineDirectiveMode)native.lineDirectiveMode;
        set => native.lineDirectiveMode = (SlangLineDirectiveMode)value;
    }

    public bool ForceGLSLScalarBufferLayout
    {
        get => native.forceGLSLScalarBufferLayout != 0;
        set => native.forceGLSLScalarBufferLayout = value ? (byte)1 : (byte)0;
    }

    internal unsafe void AsNative(TargetDesc* ptr)
    {
        native.structureSize = new((uint)sizeof(TargetDesc));
        *ptr = native;
    }
}
