using Pragma.App.DAO.Contexts;

namespace Pragma.App.DAO
{
    public class SysContext : PragmaContext
    {
        public SysContext() : base(ConnectionData.SysConnection)
        {
        }
    }
}
