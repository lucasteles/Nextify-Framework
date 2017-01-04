using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface IMenuUnitOfWork : IUnitOfWork
    {
        IMenuSistemaRepository Menu { get; set; }
    }
    public class MenuUnitOfWork : BaseUnitOfWork, IMenuUnitOfWork
    {
        public IMenuSistemaRepository Menu { get; set; }

        public MenuUnitOfWork(
                IntraContext context,
                Func<IContext, IMenuSistemaRepository> menu
        ) : base(context)
        {
            Menu = menu(context);

        }
    }
}
