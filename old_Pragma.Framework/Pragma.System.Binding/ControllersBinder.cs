using Pragma.App.Forms.Controllers;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class ControllersBinder : IBinder
    {

        public void SetBinding(IContainer container)
        {
            container.Register<ICourseGridController, CourseGridController>();


        }
    }
}
