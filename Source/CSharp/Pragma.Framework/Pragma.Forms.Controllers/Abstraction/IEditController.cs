using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.Controls.Forms;
using ModelViewBinder;
using System;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public interface IEditController<TEntity, TKey> : IDisposable
        where TEntity : class, IModelWithKey<TKey>, new()
    {
        Task<IModelViewBinder<TEntity>> UseAsync(FormEdit form, IBusiness<TEntity, TKey> business);

        TEntity Model { get; set; }

        IModelViewBinder<TEntity> Binder { get; set; }
    }

    public interface IEditController<TEntity> : IEditController<TEntity, int>
      where TEntity : class, IModelWithKey, new()
    {

    }
}