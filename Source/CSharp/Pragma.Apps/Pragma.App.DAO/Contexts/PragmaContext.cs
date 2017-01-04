using Pragma.DAO;

namespace Pragma.App.DAO.Contexts
{
    public class PragmaContext : BaseContext
    {
        public PragmaContext(string connectionString) : base(

#if DEBUG
            connectionString + "Debug"
#else
            connectionString + "Release"  
#endif

            )
        {
        }
    }
}
