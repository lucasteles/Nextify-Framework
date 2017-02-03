
using Pragma.Abstraction.IOC;
using Pragma.App.Forms.Controllers;
using Pragma.App.Forms.Controllers.Combos;

using Pragma.IOC;

namespace Pragma.App.Binding
{
    public class ControllersBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            container.Register<IConnectionComboController, ConnectionComboController>();
            container.Register<ICourseGridController, CourseGridController>();
        }

    }
}
