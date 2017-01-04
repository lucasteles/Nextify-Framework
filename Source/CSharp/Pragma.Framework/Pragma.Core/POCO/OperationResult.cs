using System.Collections.Generic;

namespace Pragma.Core
{
    public class OperationResult : IOperationResult
    {
        public IList<IErrorMessage> ErrorList { get; set; }

        public bool Success { get; set; }

    }

    public class ErrorMessage : IErrorMessage
    {
        public string Code { get; set; }

        public object Value { get; set; }
        public FailureSeverity Severity { get; set; }

        public string Message { get; set; }

        public string Property { get; set; }

    }

}
