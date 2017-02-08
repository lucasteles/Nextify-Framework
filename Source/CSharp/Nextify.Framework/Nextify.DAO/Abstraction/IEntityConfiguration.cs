using Nextify.Core;
using System;
using System.Data.Entity.ModelConfiguration;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nextify.DAO.Abstraction
{
    public interface IEntityConfiguration<T> where T : class
    {
        EntityTypeConfiguration<T> GetConfiguration();
            
    }

  }