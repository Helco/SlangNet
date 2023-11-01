using static SlangNet.Unsafe.SlangCompileTarget;

namespace SlangNet;

public enum CompileTarget
{
    Unknown = SLANG_TARGET_UNKNOWN,
    None = SLANG_TARGET_NONE,
    GLSL = SLANG_GLSL,
    GLSLVulkan = SLANG_GLSL_VULKAN,
    GLSLVulkanOneDesc = SLANG_GLSL_VULKAN_ONE_DESC,
    HLSL = SLANG_HLSL,
    SPIRV = SLANG_SPIRV,
    SPIRVAssembly = SLANG_SPIRV_ASM,
    DXBC = SLANG_DXBC,
    DXBCAssembly = SLANG_DXBC_ASM,
    DXIL = SLANG_DXIL,
    DXILAssembly = SLANG_DXIL_ASM,
    C = SLANG_C_SOURCE,
    Cpp = SLANG_CPP_SOURCE,
    HostExecutable = SLANG_HOST_EXECUTABLE,
    ShaderSharedLibrary = SLANG_SHADER_SHARED_LIBRARY,
    ShaderHostCallable = SLANG_SHADER_HOST_CALLABLE,
    CUDA = SLANG_CUDA_SOURCE,
    PTX = SLANG_PTX,
    CUDAObjectCode = SLANG_CUDA_OBJECT_CODE,
    ObjectCode = SLANG_OBJECT_CODE,
    HostCppSource = SLANG_HOST_CPP_SOURCE,
    HostHostCallable = SLANG_HOST_HOST_CALLABLE,
    CppPyTorchBinding = SLANG_CPP_PYTORCH_BINDING,
}
