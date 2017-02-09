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
    public interface ITagRepository : IRepository<Tag>
    {
        
    }

    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(IContext context) : base(context)
        {


        }

    }

   
}
