using Pragma.Abstraction.IOC;
using Pragma.App.DAO;
using Pragma.IOC;

namespace Pragma.App.Binding
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
