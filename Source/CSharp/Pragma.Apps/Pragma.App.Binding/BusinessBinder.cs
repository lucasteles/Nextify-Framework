
using Pragma.Abstraction.IOC;
using Pragma.App.Business;

using Pragma.IOC;

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
