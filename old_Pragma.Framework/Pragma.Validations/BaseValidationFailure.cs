using FluentValidation.Results;
using Pragma.Core;

namespace Pragma.Validations
{
    public class BaseValidationFailure : ValidationFailure
    {
        /// <summary>
        /// Severidade do failure.
        /// </summary>
        public FailureSeverity Severity { get; private set; } = FailureSeverity.Error;


        /// <summary>
        /// Indica se o failure representa um erro.
        /// </summary>
        public bool HasErrors { get { return Severity == FailureSeverity.Error || Severity == FailureSeverity.Warning; } }

        public BaseValidationFailure(ValidationFailure failure, FailureSeverity severity) : base(failure.PropertyName, failure.ErrorMessage, failure.AttemptedValue)
        {
            this.CustomState = failure.CustomState;
            this.ErrorCode = ErrorCode;
            this.FormattedMessageArguments = failure.FormattedMessageArguments;
            this.FormattedMessagePlaceholderValues = failure.FormattedMessagePlaceholderValues;
            this.ResourceName = failure.ResourceName;


            //Custom Properties
            this.Severity = severity;
        }
        public BaseValidationFailure(string propertyName, string error) : base(propertyName, error, null)
        {

        }
        public BaseValidationFailure(string propertyName, string error, object attemptedValue) : base(propertyName, error, attemptedValue)
        {

        }
    }
}
