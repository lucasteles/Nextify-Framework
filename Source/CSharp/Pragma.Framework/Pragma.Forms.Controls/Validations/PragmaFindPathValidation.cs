using FluentValidation;
using Pragma.Core;
using Pragma.Validations;
using System.IO;

namespace Pragma.Forms.Controls.Validations
{
    public class PragmaFindPathValidation : BaseValidator<PragmaFindPath>
    {
        public PragmaFindPathValidation()
        {
            RuleFor(i => i).Must(BeValidPath)
                .WithErrorCode("Destino inválido!")
                .WithMessage("Não foi possível encontrar o arquivo ou caminho selecionado.");
        }
        public static bool BeValidPath(PragmaFindPath tFindFile)
        {
            var ok = true;

            if (!tFindFile.txtFind.Enabled)
                return true;
            if (tFindFile.txtFind.IsEmpty())
                return true;

            if (tFindFile.SearchType == BrowserType.OpenFiles)
                ok = File.Exists(tFindFile.txtFind.Text);
            if (tFindFile.SearchType == BrowserType.Directories)
                ok = Directory.Exists(tFindFile.txtFind.Text);

            if (!ok)
                tFindFile.txtFind.BackColor = PragmaColor.VermelhoError;

            return ok;
        }
    }
}
