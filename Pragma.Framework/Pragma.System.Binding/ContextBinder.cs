using Pragma.App.DAO;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class ContextBinder : IBinder
    {

        public void SetBinding(IContainer container)
        {
            container.Register<InvestContext>(Lifecircle.InResolutionScope);
        }
    }
}
