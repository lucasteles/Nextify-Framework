using Equin.ApplicationFramework;
using Pragma.Abstraction;
using Pragma.Abstraction.Business;
using Pragma.Abstraction.Forms.Controls;
using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controllers.Abstraction
{
    public abstract class AbstractGridBusinessController<TModel, TKey, TView> : AbstractGridSimpleBusinessController<TModel, TView> where TModel : class, IModelWithKey<TKey>, new()
    {
        private List<object> NestingValues { get; set; }
        private Func<TView, object> ChildProperty { get; set; }
        private Func<TView, object> FatherProperty { get; set; }
        protected AbstractGridBusinessController(IBusiness<TModel, TKey> business) : base(business)
        {
            Business = business;
        }

        protected override void ToggleNestedVisibility(DataGridViewCellMouseEventArgs eventArgs)
        {
            if (!IsNested || eventArgs.Button != MouseButtons.Left || eventArgs.RowIndex < 0)
                return;

            var value = FatherProperty(GetSelected());
            if (NestingValues.Contains(value))
                NestingValues.Remove(value);
            else
                NestingValues.Add(value);

            NestingComparer = new Comparer(FatherProperty, ChildProperty, GridList);

            GridList.Refresh();
        }

        protected void UseNesting(object value, Func<TView, object> fatherProperty, Func<TView, object> childProperty)
        {
            IsNested = true;
            NestingValues = new List<object>(new object[] { value });
            ChildProperty = childProperty;
            FatherProperty = fatherProperty;
            NestingComparer = new Comparer(FatherProperty, ChildProperty, GridList);
        }
        protected override void Dummy()
        {
            if (!IsNested)
                return;
            NestingComparer = new Comparer(FatherProperty, ChildProperty, GridList);
        }

        protected override bool DoNestingFilter(TView model)
        {
            if (!IsNested)
                return true;

            return NestingValues.Contains(ChildProperty(model));
        }

        public async override Task<IOperationResult> TryDelete(object id)
        {
            if (!(id is TKey))
                throw new Exception("Id types dont match");

            var item = (Business as IBusiness<TModel, TKey>).GetById((TKey)id);

            var result = await Business.RemoveAsync(item);

            return result;
        }

        public async override Task<IOperationResult> TryInativate(object id)
        {
            if (!(id is TKey))
                throw new Exception("Id types dont match");

            var item = (Business as IBusiness<TModel, TKey>).GetById((TKey)id);

            var result = await Business.InativeAsync(item);

            return result;
        }
        class Comparer : IComparer<TView>
        {
            private BindingListView<TView> GridList;

            private Func<TView, object> ChildProperty { get; set; }
            private Func<TView, object> FatherProperty { get; set; }

            public Comparer(Func<TView, object> fatherProperty, Func<TView, object> childProperty, BindingListView<TView> gridList)
            {
                ChildProperty = childProperty;
                FatherProperty = fatherProperty;
                GridList = gridList;
            }

            public int Compare(TView x, TView y)
            {
                if (ChildProperty(x) == ChildProperty(y))
                    return ChildProperty(x).ToString().CompareTo(ChildProperty(y).ToString());

                var listX = GetParents(x);
                var listY = GetParents(y);

                for (int i = 0; i < listX.Count; i++)
                {
                    if (listX[i].Equals(listY[i]))
                        continue;
                    if (i == listY.Count)
                        return 1;

                    return FatherProperty(listX[i]).ToString().CompareTo(FatherProperty(listY[i]).ToString());
                }
                return -1;
            }

            private List<TView> GetParents(TView item)
            {
                var father = ((List<TView>)GridList.DataSource).Find(i => FatherProperty(i) == ChildProperty(item));

                if (father == null)
                    return new List<TView>(new TView[] { item });
                else
                {
                    var list = GetParents(father);
                    list.Add(item);
                    return list;
                }
            }
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
        public async override Task UseAsync(IPragmaDataGrid grid)
        {
            if (loaded)
                return;

            loaded = true;

            await base.UseAsync(grid);

            if (UseDatabaseDynamicSearch)
            {
                PgmGrid.UseCustomFilter = true;

                var change = Observable.FromEventPattern<EventArgs>(grid, nameof(grid.FilterTextChanged));

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
