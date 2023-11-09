using static SlangNet.Unsafe.SlangContainerFormat;

namespace SlangNet;

public enum ContainerFormat : uint
{
    None = SLANG_CONTAINER_FORMAT_NONE,
    SlangModule = SLANG_CONTAINER_FORMAT_SLANG_MODULE
}
