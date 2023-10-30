using SlangNet.Unsafe;

namespace SlangNet;

/// <include file='SlangPathType.xml' path='doc/member[@name="SlangPathType"]/*' />
[NativeTypeName("SlangPathTypeIntegral")]
public enum SlangPathType : uint
{
    /// <include file='SlangPathType.xml' path='doc/member[@name="SlangPathType.SLANG_PATH_TYPE_DIRECTORY"]/*' />
    SLANG_PATH_TYPE_DIRECTORY,

    /// <include file='SlangPathType.xml' path='doc/member[@name="SlangPathType.SLANG_PATH_TYPE_FILE"]/*' />
    SLANG_PATH_TYPE_FILE,
}
