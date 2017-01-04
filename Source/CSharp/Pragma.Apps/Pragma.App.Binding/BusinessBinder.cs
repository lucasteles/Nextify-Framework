
using Pragma.App.Business;
using Pragma.App.Business.Sys;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class BusinessBinder : IBinder
    {

        public void SetBinding(IContainer container)
        {
            container.Register<IUsuarioLoginBusiness, UsuarioLoginBusiness>();
            container.Register<IConnectionBusiness, ConnectionBusiness>();
            container.Register<IIndiceBusiness, IndiceBusiness>();
            container.Register<IMenuPrincipalBusiness, MenuPrincipalBusiness>();
        }
    }
}
