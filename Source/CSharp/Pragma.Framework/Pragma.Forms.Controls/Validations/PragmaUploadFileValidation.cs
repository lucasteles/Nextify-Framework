using FluentValidation;
using Pragma.Forms.Controls;
using Pragma.Validations;
using System.IO;

namespace Pragma.Forms.Controls.Validations
{
    public class PragmaUploadFileValidation : BaseValidator<PragmaUploadFile>
    {
        public PragmaUploadFileValidation()
        {
            RuleFor(i => i).Must(BeValidPath)
                .WithErrorCode("Destino inválido!")
                .WithMessage("Não foi possível encontrar o arquivo selecionado.");
        }
        public bool BeValidPath(PragmaUploadFile tFindFile)
        {
            var ok = true;
            return ok;
        }
    }
}
