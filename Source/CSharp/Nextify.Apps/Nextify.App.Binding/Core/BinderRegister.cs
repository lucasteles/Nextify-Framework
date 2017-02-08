using Nextify.Abstraction.IOC;
using Nextify.IOC;

namespace Nextify.App.Binding
{
    public class BinderRegister
    {
        public void RegisterBinders(IContainer container)
        {
            container.RegisterBinders(
                    new FrameworkBinders(),
                    new DaoBinder(),
                    new BusinessBinder(),
                    new ToolsBinder(),
                    new ValidationBinder(),
                    new ContextBinder(),
                    new ControllersBinder()
                );

        }
    }
}
