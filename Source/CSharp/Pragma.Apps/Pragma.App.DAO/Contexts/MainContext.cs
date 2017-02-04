using System.Data.Entity;
using Pragma.DAO;
using Pragma.App.Models;

namespace Pragma.App.DAO
{
    public class MainContext : BaseContext
    {

        public MainContext() : base(ConnectionData.MainConnection)
        {

           
        }
    

    }
}
