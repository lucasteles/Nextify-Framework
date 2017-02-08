using Nextify.Abstraction;
using Nextify.Abstraction.Business;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Business.Abstraction;
using Nextify.Core;
using Nextify.Forms.Controls;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Nextify.Forms.Controllers.Abstraction
{
    public abstract class AbstractComboSimpleBusinessController<TModel, TView, TViewKey> : AbstractComboController<TView, TViewKey> where TModel : class, new()
    {
        protected ISimpleBusiness<TModel> Business { get; set; }
        /// <summary>
        /// Define se a busca deve ser realizada no banco de dados
        /// </summary>

        protected AbstractComboSimpleBusinessController(ISimpleBusiness<TModel> business)
        {
            Business = business;
        }

        public async override Task UseAsync(INextifyComboBox combo, Expression<Func<TView, TViewKey>> key, Expression<Func<TView, object>> value)
        {
            await base.UseAsync(combo, key, value);
        }

        public override async Task RefreshAsync()
        {
            await base.RefreshAsync();
        }
        public override void Dispose()
        {
            Business.Dispose();
        }
    }
    public abstract class AbstractComboBusinessController<TModel> : AbstractComboBusinessController<TModel, int, TModel, int> where TModel : class, IModelWithKey, new()
    {
        protected AbstractComboBusinessController(IBusiness<TModel, int> business) : base(business)
        {
        }
    }
    public abstract class AbstractComboBusinessController<TModel, TKey> : AbstractComboBusinessController<TModel, TKey, TModel, TKey> where TModel : class, IModelWithKey<TKey>, new()
    {
        protected AbstractComboBusinessController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
    }
    public abstract class AbstractComboBusinessController<TModel, TKey, TView> : AbstractComboBusinessController<TModel, TKey, TView, TKey> where TModel : class, IModelWithKey<TKey>, new()
    {
        protected AbstractComboBusinessController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
    }
    public abstract class AbstractComboBusinessController<TModel, TKey, TView, TViewKey> : AbstractComboSimpleBusinessController<TModel, TView, TViewKey> where TModel : class, IModelWithKey<TKey>, new()
    {
        protected AbstractComboBusinessController(IBusiness<TModel, TKey> business) : base(business)
        {
            Business = business;
        }
    }
}
