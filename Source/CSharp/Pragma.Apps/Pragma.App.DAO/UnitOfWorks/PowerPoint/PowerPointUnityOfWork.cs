using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface IPowerPointUnitOfWork : IUnitOfWork
    {
        IPptPaginaRepository PptPagina { get; set; }
        IPptPaginaImportadaRepository PptPaginaImportada { get; set; }
        IPptRelatorioInvestimentoRepository PptRelatorioInvestimento { get; set; }
        IPptRelatorioPaginaRepository PptRelatorioPagina { get; set; }
        IPptRelatorioRepository PptRelatorio { get; set; }
        IPptRotinaRepository PptRotina { get; set; }
    }
    public class PowerPointUnitOfWork : BaseUnitOfWork, IPowerPointUnitOfWork
    {
        public IPptPaginaRepository PptPagina { get; set; }
        public IPptPaginaImportadaRepository PptPaginaImportada { get; set; }
        public IPptRelatorioInvestimentoRepository PptRelatorioInvestimento { get; set; }
        public IPptRelatorioPaginaRepository PptRelatorioPagina { get; set; }
        public IPptRelatorioRepository PptRelatorio { get; set; }
        public IPptRotinaRepository PptRotina { get; set; }

        public PowerPointUnitOfWork(
                InvestContext context,
                Func<IContext, IPptPaginaRepository> pptPagina,
                Func<IContext, IPptPaginaImportadaRepository> pptPaginaImportada,
                Func<IContext, IPptRelatorioInvestimentoRepository> pptRelatorioInvestimento,
                Func<IContext, IPptRelatorioPaginaRepository> pptRelatorioPagina,
                Func<IContext, IPptRelatorioRepository> pptRelatorio,
                Func<IContext, IPptRotinaRepository> pptRotina

        ) : base(context)
        {
            PptPagina = pptPagina(context);
            PptPaginaImportada = pptPaginaImportada(context);
            PptRelatorioInvestimento = pptRelatorioInvestimento(context);
            PptRelatorioPagina = pptRelatorioPagina(context);
            PptRelatorio = pptRelatorio(context);
            PptRotina = pptRotina(context);
        }
    }
}
