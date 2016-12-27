using Pragma.App.DAO;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class DaoBinder : IBinder
    {

        public void SetBinding(IContainer container)
        {


            container.Register<ITestUnityOfWork, TestUnityOfWork>();
            container.Register<ICoursesRepository, CoursesRepository>();
            container.Register<IAuthorRepository, AuthorRepository>();

        }
    }
}
