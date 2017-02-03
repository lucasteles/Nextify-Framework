using Pragma.Abstraction.IOC;
using Pragma.IOC;

namespace Pragma.App.Binding
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
