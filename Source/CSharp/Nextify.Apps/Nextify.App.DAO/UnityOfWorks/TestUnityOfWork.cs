using Nextify.Abstraction.DAO;
using Nextify.DAO;
using Nextify.DAO.Abstraction;
using System;

namespace Nextify.App.DAO
{


    public interface ICourseUnityOfWork : IUnitOfWork
    {
        ICoursesRepository Courses { get; set; }
        IAuthorRepository Authors { get; set; }
        
    }

    public class CourseUnityOfWork : BaseUnitOfWork, ICourseUnityOfWork
    {
        
        public ICoursesRepository Courses { get; set; }
        public IAuthorRepository Authors { get; set; }

        public CourseUnityOfWork(
                MainContext context,
                Func<IContext,ICoursesRepository> _courses,
                Func<IContext, IAuthorRepository> _authors

        ) : base(context)
        {
            Courses = _courses(context);
            Authors = _authors(context);
        }

    }



}
