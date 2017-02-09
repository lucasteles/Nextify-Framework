
using Nextify.Abstraction.IOC;
using Nextify.App.Business;

using Nextify.IOC;

namespace Nextify.App.Binding
{
    public class BusinessBinder : IBinder
    {

        public void SetBinding(IContainer container)
        {
            container.Register<ICoursesBusiness, CoursesBusiness>();
            container.Register<ICoursesBusiness, CoursesBusiness>();
            container.Register<IAuthorBusiness, AuthorBusiness>();
            container.Register<ITagBusiness, TagBusiness>();

        }
    }
}
