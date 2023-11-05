using static SlangNet.Unsafe.SlangResourceAccess;

namespace SlangNet;

public enum ResourceAccess : uint
{
    None = SLANG_RESOURCE_ACCESS_NONE,
    Read = SLANG_RESOURCE_ACCESS_READ,
    ReadWrite = SLANG_RESOURCE_ACCESS_READ_WRITE,
    RasterOrdered = SLANG_RESOURCE_ACCESS_RASTER_ORDERED,
    Append = SLANG_RESOURCE_ACCESS_APPEND,
    Consume = SLANG_RESOURCE_ACCESS_CONSUME,
    Write = SLANG_RESOURCE_ACCESS_WRITE
}
