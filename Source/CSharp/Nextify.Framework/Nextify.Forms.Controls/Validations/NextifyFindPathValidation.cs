using FluentValidation;
using Nextify.Core;
using Nextify.Validations;
using System.IO;

namespace Nextify.Forms.Controls.Validations
{
    public class NextifyFindPathValidation : BaseValidator<NextifyFindPath>
    {
        public NextifyFindPathValidation()
        {
            RuleFor(i => i).Must(BeValidPath)
                .WithErrorCode("Destino inválido!")
                .WithMessage("Não foi possível encontrar o arquivo ou caminho selecionado.");
        }
        public static bool BeValidPath(NextifyFindPath tFindFile)
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
                tFindFile.txtFind.BackColor = ColorTool.VermelhoError;

            return ok;
        }
    }
}
