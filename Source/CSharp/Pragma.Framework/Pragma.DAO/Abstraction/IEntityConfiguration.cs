using Pragma.Core;
using System;
using System.Data.Entity.ModelConfiguration;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.DAO.Abstraction
{
    internal interface IEntityConfiguration<T> where T : class
    {
        EntityTypeConfiguration<T> GetConfiguration();
            
    }

  }