using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface IFinanceUnitOfWork : IUnitOfWork
    {
        IIndiceRepository Indice { get; set; }
        IIndiceCotacaoRepository IndiceCotacao { get; set; }

    }
    public class FinanceUnitOfWork : BaseUnitOfWork, IFinanceUnitOfWork
    {
        public IIndiceRepository Indice { get; set; }

        public IIndiceCotacaoRepository IndiceCotacao { get; set; }

        public FinanceUnitOfWork(
                InvestContext context,
                Func<IContext, IIndiceRepository> indice,
                Func<IContext, IIndiceCotacaoRepository> indiceCotacao

        ) : base(context)
        {
            Indice = indice(context);
            IndiceCotacao = indiceCotacao(context);

        }
    }
}
