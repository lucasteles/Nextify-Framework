using Pragma.DAO;
using Pragma.DAO.Abstraction;
using Pragma.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pragma.Abstraction.DAO;
using System.Data.Entity;

namespace Pragma.App.DAO
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
