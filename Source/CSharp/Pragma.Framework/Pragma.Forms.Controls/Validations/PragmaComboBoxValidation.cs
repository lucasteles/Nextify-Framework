using FluentValidation;
using Pragma.Core;

using Pragma.Validations;

namespace Pragma.Forms.Controls.Validations
{
    public class PragmaComboBoxValidation : BaseValidator<PragmaComboBox>
    {

        public PragmaComboBoxValidation()
        {
            RuleFor(i => i.Text).NotNull().NotEqual("").When(i => i.Required)
                                .SetSeverity(FailureSeverity.Warning)
                                .WithMessage(Messages.Required);
        }
    }
}
