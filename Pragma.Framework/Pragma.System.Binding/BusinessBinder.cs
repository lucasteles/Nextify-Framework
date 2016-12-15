
using Pragma.IOC.Abstraction;
using Pragma.IOC;
using Pragma.App.Business;

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
