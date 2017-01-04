using Pragma.App.Business;
using Pragma.App.Model;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls;

namespace Pragma.App.Forms.Controllers.Combos
{
    public interface IConnectionComboController : IComboController<DbComboConnection, string>
    {
    }
    public class ConnectionComboController : ComboBusinessController<DbComboConnection, int, string>, IConnectionComboController
    {
        public ConnectionComboController(IConnectionBusiness business) : base(business)
        {
            FilterInative = true;

#if !DEBUG
                SetOrdem(o => o.Ordem);
#endif
        }

        public override void SelectedChanceItem(DbComboConnection o)
        {
            base.SelectedChanceItem(o);
        }
    }
}
