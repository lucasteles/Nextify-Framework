
using Nextify.Abstraction;

using ModelViewBinder;
using System;
using System.Threading.Tasks;
using Nextify.Abstraction.Business;
using Nextify.Core;

namespace Nextify.Abstraction.Forms.Controllers
{
    public interface IFormEdit
    {
        object ID { get; set; }
        object ItemsModel { get; set; }
        bool PersistData { get; set; }

        Task FormAfterLoadAsync();
        void RefreshControls();
        void RefreshModel();
        void Show(object id);
        void Show<TModel>(TModel model) where TModel : class, new();
        void ShowDialog(object id);
        void ShowDialog<TModel>(TModel model) where TModel : class, new();
        bool ShowMessage(IOperationResult operation, string title = null);
    }

    public interface IEditController<TEntity, TKey> : IDisposable
        where TEntity : class, IModelWithKey<TKey>, new()
    {
        Task<IModelViewBinder<TEntity>> UseAsync(IFormEdit form, IBusiness<TEntity, TKey> business);

        TEntity Model { get; set; }

        IModelViewBinder<TEntity> Binder { get; set; }
    }

    public interface IEditController<TEntity> : IEditController<TEntity, int>
      where TEntity : class, IModelWithKey, new()
    {

    }
}