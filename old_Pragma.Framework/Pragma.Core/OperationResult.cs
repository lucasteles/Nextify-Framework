using System.Collections.Generic;
using System.Linq;

namespace Pragma.Core
{
    public class OperationResult : IOperationResult
    {
        public IList<IErrorMessage> ErrorList { get; set; }


        public bool Success { get; set; }

        public static IOperationResult CreateResult(bool valid, IEnumerable<string> Messages)
        {
            return new OperationResult()
            {
                Success = valid,
                ErrorList = Messages.Select(e => (IErrorMessage)new ErrorMessage() { Message = e }).ToList()
            };
        }

        public static IOperationResult CreateResult(bool valid, IEnumerable<IErrorMessage> Messages)
        {
            return new OperationResult()
            {
                Success = valid,
                ErrorList = Messages.ToList()
            };
        }
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
