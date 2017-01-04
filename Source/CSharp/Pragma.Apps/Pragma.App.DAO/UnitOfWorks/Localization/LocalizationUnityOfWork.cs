using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface ILocalizationUnitOfWork : IUnitOfWork
    {
        IFeriadoRepository Feriado { get; set; }
    }
    public class LocalizationUnitOfWork : BaseUnitOfWork, ILocalizationUnitOfWork
    {
        public IFeriadoRepository Feriado { get; set; }

        public LocalizationUnitOfWork(
                SysContext context,
                Func<IContext, IFeriadoRepository> feriado
        ) : base(context)
        {
            Feriado = feriado(context);
        }
    }
}
