namespace SlangNet.RHI.Unsafe;

/// <include file='CooperativeVectorMatrixLayout.xml' path='doc/member[@name="CooperativeVectorMatrixLayout"]/*' />
public enum CooperativeVectorMatrixLayout
{
    /// <include file='CooperativeVectorMatrixLayout.xml' path='doc/member[@name="CooperativeVectorMatrixLayout.RowMajor"]/*' />
    RowMajor = 0,

    /// <include file='CooperativeVectorMatrixLayout.xml' path='doc/member[@name="CooperativeVectorMatrixLayout.ColumnMajor"]/*' />
    ColumnMajor = 1,

    /// <include file='CooperativeVectorMatrixLayout.xml' path='doc/member[@name="CooperativeVectorMatrixLayout.InferencingOptimal"]/*' />
    InferencingOptimal = 2,

    /// <include file='CooperativeVectorMatrixLayout.xml' path='doc/member[@name="CooperativeVectorMatrixLayout.TrainingOptimal"]/*' />
    TrainingOptimal = 3,
}
