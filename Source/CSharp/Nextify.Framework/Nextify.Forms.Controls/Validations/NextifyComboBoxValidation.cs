using FluentValidation;
using Nextify.Core;

using Nextify.Validations;

namespace Nextify.Forms.Controls.Validations
{
    public class NextifyComboBoxValidation : BaseValidator<NextifyComboBox>
    {

        public NextifyComboBoxValidation()
        {
            RuleFor(i => i.Text).NotNull().NotEqual("").When(i => i.Required)
                                .SetSeverity(FailureSeverity.Warning)
                                .WithMessage(Messages.Required);
        }
    }
}
