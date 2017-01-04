using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface IGalgoUnitOfWork : IUnitOfWork
    {
        IGalgoRepository Galgo { get; set; }
        IGalgoLogRepository GalgoLog { get; set; }
    }
    public class GalgoUnitOfWork : BaseUnitOfWork, IGalgoUnitOfWork
    {
        public IGalgoRepository Galgo { get; set; }
        public IGalgoLogRepository GalgoLog { get; set; }

        public GalgoUnitOfWork(
                InvestContext context,
                Func<IContext, IGalgoRepository> galgo,
                Func<IContext, IGalgoLogRepository> galgoLog

        ) : base(context)
        {
            Galgo = galgo(context);
            GalgoLog = galgoLog(context);
        }
    }
}
