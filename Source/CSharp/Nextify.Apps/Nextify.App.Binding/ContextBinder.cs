using Nextify.Abstraction.IOC;
using Nextify.App.DAO;
using Nextify.Core;
using Nextify.IOC;

namespace Nextify.App.Binding
{
    public class ContextBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            container.Register<MainContext>(Lifecircle.InResolutionScope);
        }
    }
}
