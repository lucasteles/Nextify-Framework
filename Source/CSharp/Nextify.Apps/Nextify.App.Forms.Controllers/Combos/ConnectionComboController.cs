using System.Collections.Generic;
using System.Threading.Tasks;
using Nextify.App.Business;

using Nextify.Forms.Controllers;
using Nextify.Forms.Controls;
using Nextify.Abstraction.Forms.Controls;

namespace Nextify.App.Forms.Controllers.Combos
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
