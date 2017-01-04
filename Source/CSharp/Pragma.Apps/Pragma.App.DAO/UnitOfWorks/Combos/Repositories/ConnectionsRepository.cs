using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragma.App.DAO.Repositories
{
    public interface IConnectionsRepository : IRepository<DbComboConnection>
    {

    }

    public class ConnectionsRepository : BaseRepository<DbComboConnection>, IConnectionsRepository
    {
        public ConnectionsRepository(IContext context) : base(context) 
        {
        }
    }
}
