using Pragma.DAO;
using Pragma.DAO.Abstraction;


namespace Pragma.App.DAO
{


    public interface ITestUnityOfWork : IUnityOfWork
    {
        ICoursesRepository Courses { get; set; }
        IAuthorRepository Authors { get; set; }


    }

    public class TestUnityOfWork : UnityOfWork, ITestUnityOfWork
    {


        public ICoursesRepository Courses { get; set; }
        public IAuthorRepository Authors { get; set; }

        public TestUnityOfWork(
                InvestContext context,
                ICoursesRepository _courses,
                IAuthorRepository _authors

        ) : base(context)
        {


            Set(_courses, () => Courses);
            Set(_authors, () => Authors);


        }

    }



}
