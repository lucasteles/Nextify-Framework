using Pragma.Abstraction.IOC;
using Pragma.App.DAO;
using Pragma.Core;
using Pragma.IOC;

namespace Pragma.App.Binding
{
    public class ContextBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            container.Register<MainContext>(Lifecircle.InResolutionScope);
        }
    }
}
