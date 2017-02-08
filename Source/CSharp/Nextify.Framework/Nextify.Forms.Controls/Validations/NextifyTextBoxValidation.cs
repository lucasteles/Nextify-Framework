using FluentValidation;
using Nextify.Core;

using Nextify.Validations;

namespace Nextify.Forms.Controls.Validations
{
    public class NextifyTextBoxValidation : BaseValidator<NextifyTextBox>
    {

        public NextifyTextBoxValidation()
        {
            RuleFor(i => i.Text).NotNull().NotEqual("").When(i => i.Required)
                                .SetSeverity(FailureSeverity.Warning)
                                .WithMessage(Messages.Required);
        }

    }
}
