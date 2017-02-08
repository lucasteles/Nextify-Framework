using FluentValidation;
using Nextify.Forms.Controls;
using Nextify.Validations;
using System.IO;

namespace Nextify.Forms.Controls.Validations
{
    public class NextifyUploadFileValidation : BaseValidator<NextifyUploadFile>
    {
        public NextifyUploadFileValidation()
        {
            RuleFor(i => i).Must(BeValidPath)
                .WithErrorCode("Destino inválido!")
                .WithMessage("Não foi possível encontrar o arquivo selecionado.");
        }
        public bool BeValidPath(NextifyUploadFile tFindFile)
        {
            var ok = true;
            return ok;
        }
    }
}
