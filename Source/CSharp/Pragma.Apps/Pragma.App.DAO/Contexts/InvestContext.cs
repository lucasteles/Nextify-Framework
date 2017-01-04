using Pragma.App.DAO.Contexts;
using Pragma.DAO;

namespace Pragma.App.DAO
{
    public class InvestContext : PragmaContext
    {
        public InvestContext() : base(ConnectionData.MainConnection)
        {
        }
    }
}
