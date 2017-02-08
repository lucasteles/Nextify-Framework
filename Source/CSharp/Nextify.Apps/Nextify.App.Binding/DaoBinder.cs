using Nextify.Abstraction.IOC;
using Nextify.App.DAO;
using Nextify.IOC;

namespace Nextify.App.Binding
{
    public class DaoBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            container.Register<ICourseUnityOfWork, CourseUnityOfWork>();
            container.Register<ICoursesRepository, CoursesRepository>();
            container.Register<IAuthorRepository, AuthorRepository>();
        }
    }
}
