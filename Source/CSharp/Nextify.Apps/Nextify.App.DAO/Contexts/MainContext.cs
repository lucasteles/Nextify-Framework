using System.Data.Entity;
using Nextify.DAO;
using Nextify.App.Models;

namespace Nextify.App.DAO
{
    public class MainContext : BaseContext
    {

        public MainContext() : base(ConnectionData.MainConnection)
        {

           
        }
    

    }
}
