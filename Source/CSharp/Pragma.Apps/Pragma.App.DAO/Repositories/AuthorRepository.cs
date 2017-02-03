using Pragma.DAO;
using Pragma.DAO.Abstraction;
using Pragma.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pragma.Abstraction.DAO;

namespace Pragma.App.DAO
{
    public interface IAuthorRepository : IRepository<Author>
    {

    }

    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(IContext context) : base(context)
        {
        }
    }

   
}
