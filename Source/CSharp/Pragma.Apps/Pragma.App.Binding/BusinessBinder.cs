
using Pragma.App.Business;

using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class BusinessBinder : IBinder
    {

        public void SetBinding(IContainer container)
        {
            container.Register<ICoursesBusiness, CoursesBusiness>();

        }
    }
}
