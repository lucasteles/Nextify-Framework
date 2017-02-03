using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Pragma.DAO
{
    public class EntityFrameworkConfiguration : DbConfiguration
    {
        public EntityFrameworkConfiguration()
        {
            SetModelCacheKey(ctx => new EntityModelCacheKey( (ctx.GetType().FullName + ctx.Database.Connection.ConnectionString).GetHashCode()  ));
        }
    }


    public class EntityModelCacheKey : IDbModelCacheKey
    {
        private readonly int _hashCode;

        public EntityModelCacheKey(int hashCode)
        {
            _hashCode = hashCode;
        }

        public override bool Equals(object other)
        {
            if (other == null) return false;
            return other.GetHashCode() == _hashCode;
        }

        public override int GetHashCode()
        {
            return _hashCode;
        }
    }
}
