using Pragma.App.DAO.Contexts;

namespace Pragma.App.DAO
{
    public class IntraContext : PragmaContext
    {
        public IntraContext() : base(ConnectionData.IntraConnection)
        {
        }
    }
}
