using System.Collections.Generic;
using System.Linq;

namespace Pragma.Core
{
    public class OperationResult : IOperationResult
    {
        public IList<IErrorMessage> ErrorList { get; set; }

        public bool Success { get; set; }





        public static IOperationResult BadResult(params string[] Messages)
        {
            return CreateResult(false, FailureSeverity.Warning, Messages);

        }

        public static IOperationResult CreateResult(bool valid, FailureSeverity severity, params string[] Messages)
        {
            return new OperationResult
            {
                Success = valid,
                ErrorList = Messages.Select(e => (IErrorMessage)new ErrorMessage { Message = e, Severity = severity }).ToList()

            };
        }

        public static IOperationResult CreateResult(bool valid, params string[] Messages)
        {
            return CreateResult(valid, FailureSeverity.Warning, Messages);

        }

        public static IOperationResult CreateResult(bool valid, params IErrorMessage[] Messages)
        {
            return new OperationResult
            {
                Success = valid,
                ErrorList = Messages.ToList()
            };
        }

        public static IOperationResult Ok()
        {
            return new OperationResult { Success = true, ErrorList = new List<IErrorMessage>() };
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
