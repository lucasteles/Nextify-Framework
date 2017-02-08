using Nextify.DAO;
using Nextify.DAO.Abstraction;
using Nextify.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nextify.Abstraction.DAO;
using System.Data.Entity;

namespace Nextify.App.DAO
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task GetAuthorWIthCoursesLevelGreaterThan(Author author, int level);
    }

    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(IContext context) : base(context)
        {


        }

        public async Task GetAuthorWIthCoursesLevelGreaterThan(Author author, int level)
        {
             await Context.Entry(author)
                            .Collection(e => e.Courses)
                            .Query()
                            .Where(e => e.Level >= level)
                            .LoadAsync();

            
        }
    }

   
}
