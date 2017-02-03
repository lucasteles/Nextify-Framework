
using System.Collections.Generic;

namespace  Pragma.Core
{
    public interface IOperationResult
    {
        IList<IErrorMessage> ErrorList { get; set; }
        bool Success { get; set; }

    }

    public interface IErrorMessage
    {
        string Message { get; set; }
        string Property { get; set; }
        object Value { get; set; }
        string Code { get; set; }

        FailureSeverity Severity { get; set; }
    }

}
