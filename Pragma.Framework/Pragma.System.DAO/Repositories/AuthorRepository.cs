using Pragma.DAO;
using Pragma.DAO.Abstraction;
using Pragma.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragma.App.DAO
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {


    }

    public interface IAuthorRepository : IRepository<Author>
    {

    }
}
