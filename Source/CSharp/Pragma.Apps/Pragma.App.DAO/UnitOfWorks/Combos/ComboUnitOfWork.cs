using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface IComboUnitOfWork : IUnitOfWork
    {
        IConnectionsRepository Connections { get; set; }
    }
    public class ComboUnitOfWork : BaseUnitOfWork, IComboUnitOfWork
    {
        public IConnectionsRepository Connections { get; set; }

        public ComboUnitOfWork(
                IntraContext context,
                 Func<IContext, IConnectionsRepository> connections
        ) : base(context)
        {
            Connections = connections(context);

        }
    }
}
