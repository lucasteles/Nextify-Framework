using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.Controls;
using System;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers.Abstraction
{
    public abstract class AbstractGridBusinessController<TModel, TKey, TView> : AbstractGridSimpleBusinessController<TModel, TView> where TModel : class, IModelWithKey<TKey>, new()
    {
        protected AbstractGridBusinessController(IBusiness<TModel, TKey> business) : base(business)
        {
            Business = business;
        }

        public async override Task<IOperationResult> TryDelete(object id)
        {
            if (!(id is TKey))
                throw new Exception("Id types dont match");

            var item = (Business as IBusiness<TModel, TKey>).Get((TKey)id);

            var result = await Business.RemoveAsync(item);

            return result;
        }

        public async override Task<IOperationResult> TryInativate(object id)
        {
            if (!(id is TKey))
                throw new Exception("Id types dont match");

            var item = (Business as IBusiness<TModel, TKey>).Get((TKey)id);

            var result = await Business.InativeAsync(item);

            return result;
        }
    }

    public abstract class AbstractGridSimpleBusinessController<TModel, TView> : AbstractGridController<TView> where TModel : class, new()
    {
        public ISimpleBusiness<TModel> Business;
        private IDisposable TextChange;
        private bool loaded;
        /// <summary>
        /// Define se a busca deve ser realizada no banco de dados
        /// </summary>
        public bool UseDatabaseDynamicSearch { get; set; } = false;

        protected AbstractGridSimpleBusinessController(ISimpleBusiness<TModel> business)
        {
            Business = business;
        }
        public async override Task UseAsync(PragmaDataGrid grid)
        {
            if (loaded)
                return;

            loaded = true;

            await base.UseAsync(grid);

            if (UseDatabaseDynamicSearch)
            {
                PgmGrid.UseCustomFilter = true;

                var change =
                     Observable.FromEventPattern<EventArgs>(grid, nameof(grid.FilterTextChanged));
                TextChange = change
                    .Throttle(TimeSpan.FromSeconds(.5))
                    .ObserveOn(PgmGrid)
                    .Subscribe(async evt =>
                    {
                        await RefreshAsync();
                    });
            }
        }

        public abstract Task RefreshDynamicSearchAsync();

        public override async Task RefreshAsync()
        {
            if (!UseDatabaseDynamicSearch || string.IsNullOrEmpty(PgmGrid.FilterText))
            {
                await base.RefreshAsync();
                return;
            }

            if (PgmGrid == null)
                return;

            DoStartLoad(this, EventArgs.Empty);

            await RefreshDynamicSearchAsync();

            GetColumnsFromAttributes();

            PgmGrid.BindList(GridList, Columns);
            OrderByColumn();
            DoEndLoad(this, EventArgs.Empty);
        }

        public override void Dispose()
        {
            Business?.Dispose();
            TextChange?.Dispose();
        }
    }
}
