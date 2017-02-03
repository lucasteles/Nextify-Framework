using System.Collections.Generic;
using System.Threading.Tasks;
using Pragma.App.Business;

using Pragma.Forms.Controllers;
using Pragma.Forms.Controls;

namespace Pragma.App.Forms.Controllers.Combos
{
    public interface IConnectionComboController : IComboController<ConnectionInfo, string>
    {
    }
    public class ConnectionComboController : ComboController<ConnectionInfo, string>, IConnectionComboController
    {
        public ConnectionComboController()
        {
            FilterInative = true;
        }

        public async override Task<IEnumerable<ConnectionInfo>> GetForComboAsync()
        {
            return await Task.FromResult(AppConfiguration.GetConnections());
        }


    }
}
