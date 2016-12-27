using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.ControlBinding;
using Pragma.Forms.Controls.Forms;
using System;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public interface IEditController<TEntity, TKey> : IDisposable
        where TEntity : class, IModelWithId<TKey>, new()
        where TKey : struct
    {
        Task<IControlBinder<TEntity>> Use(FormEdit form, IBusiness<TEntity, TKey> business);

        TEntity Model { get; set; }

        IControlBinder<TEntity> Binder { get; set; }
    }

    public interface IEditController<TEntity> : IEditController<TEntity, int>
      where TEntity : class, IModelWithId, new()
    {

    }

}