using Equin.ApplicationFramework;
using Pragma.Abstraction;
using Pragma.Abstraction.Forms.Controls;
using Pragma.Core;
using Pragma.Core.Icons;
using Pragma.Excel;
using Pragma.Extensions;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controllers.Abstraction
{
    public abstract class AbstractGridController<TView> : IGridController<TView>
    {
        #region Propriedades
        private PragmaContextMenu MenuContext { get; set; }  // Menu de Contexto
        private PragmaContextMenu MenuSelection { get; set; }  // Menu da seleção do grid
        private PragmaContextMenu MenuEmptyGrid { get; set; }  // Menu da seleção do grid
        private IList<ContextMenuConfig> ContextMenuResolver { get; set; } = new List<ContextMenuConfig>();
        private bool _loaded;
        protected Expression<Func<TView, bool>> Predicate { get; set; }
        protected Func<Expression<Func<TView, bool>>, int, Task<IEnumerable<TView>>> LoadFunctionWithFilter { get; set; }
        protected Func<int, Task<IEnumerable<TView>>> LoadFunction { get; set; }
        public virtual void SetPredicate(Expression<Func<TView, bool>> predicate)
        {
            Predicate = predicate;
        }

        protected virtual Expression<Func<TView, bool>> TreatPredicate(Expression<Func<TView, bool>> predicate)
        {
            return predicate;
        }
        protected virtual async Task<IEnumerable<TView>> GetForGridAsync()
        {
            return Predicate != null || FilterInative ?
                        await LoadFunctionWithFilter?.Invoke(TreatPredicate(Predicate), QtdTopResult) :
                        await LoadFunction?.Invoke(QtdTopResult);
        }
        /// <summary>
        /// Ultima ordenação realizada.
        /// </summary>
        private Tuple<int, ListSortDirection> LastOrdering { get; set; }
        /// <summary>
        /// A Grid que o controlador usa.
        /// </summary>
        protected PragmaDataGrid PgmGrid { get; set; }

        public IList<IDisposable> Disposables { get; set; } = new List<IDisposable>();

        /// <summary>
        /// BindingList que está vinculada à Grid.
        /// </summary>
        protected BindingListView<TView> GridList { get; set; }
        /// <summary>
        /// Colunas da Grid.
        /// </summary>
        public List<PgmColumn> Columns { get; set; }
        private List<PropertyDescriptor> Properties { get; set; }
        protected bool IsNested { get; set; }
        protected IComparer<TView> NestingComparer { get; set; }
        /// <summary>
        /// Quantidade de resultados buscados da database.
        /// </summary>
        public int QtdTopResult { get; set; } = 50;
        /// <summary>
        /// Regras de formatação da Grid.
        /// </summary>
        public IModelFormatRule<TView> Format { get; set; }
            = new ModelFormatRule<TView>();
        public bool FilterInative { get; set; }
        public bool F4Mode { get; set; } = false;
        public object Value { get; set; }

        public event EventHandler StartLoad;
        public event EventHandler EndLoad;

        public void DoStartLoad(object sender, EventArgs e) => StartLoad?.Invoke(sender, e);
        public void DoEndLoad(object sender, EventArgs e) => EndLoad?.Invoke(sender, e);
        #endregion

        #region Construtores
        protected AbstractGridController()
        {
            // Menu da seleção do grid
            var item = new ToolStripMenuItem
            {
                Text = Messages.Copy,
                Image = BaseIcons.copy
            };
            item.Click += CopyToClipboard;

            MenuSelection = new PragmaContextMenu();
            MenuSelection.Items.Add(item);
        }
        #endregion

        #region Metodos
        public void ExportToExcel(IExcelTool tool, string file)
        {
            tool.ExportFromList(GetList<TView>(), file);
        }
        public virtual async Task UseAsync(IPragmaDataGrid grid)
        {
            if (PgmGrid != null && PgmGrid == grid && _loaded)
            {
                await RefreshAsync();
                return;
            }

            PgmGrid =(PragmaDataGrid) grid;

            PgmGrid.GridNotSelectedRightMouseClick += PgmGrid_GridNotSelectedRightMouseClick;
            PgmGrid.GridSelectedRightMouseClick += PgmGrid_GridSelectedRightMouseClick;
            PgmGrid.FilterTextChanged += PgmGrid_FilterTextChanged;
            PgmGrid.Grid.CellPainting += Grid_CellPainting;
            PgmGrid.Grid.ColumnHeaderMouseClick += Grid_ColumnHeaderMouseClick;
            PgmGrid.Grid.CellMouseDoubleClick += Grid_CellMouseDoubleClick;

            _loaded = true;

            await RefreshAsync();
        }

        public void SetSelectedPosition(Func<TView, bool> predicate)
        {
            var index = GridList.FindIndex(predicate);
            PgmGrid.SetSelectedRow(index);
        }
        public void SetSelectedPosition(object id)
        {
            for (var i = 0; i < GridList.Count(); i++)
            {
                if (id.Equals(GridList[i].Object.GetKeyAtributteValue()))
                {
                    PgmGrid.SetSelectedRow(i);
                    break;
                }
            }
        }
        public virtual async Task RefreshAsync()
        {
            if (PgmGrid == null)
                return;
            var atual = PgmGrid.GetSelectedRowIndex();
            DoStartLoad(this, EventArgs.Empty);
            await GetBindingListAsync();

            GetColumnsFromAttributes();

            PgmGrid.BindList(GridList, Columns);
            OrderByColumn();

            if (GridList.Count > 0)
                if (atual < GridList.Count())
                    PgmGrid.SetSelectedRow(atual);
                else
                    PgmGrid.SetSelectedRow(GridList.Count() - 1);

            DoEndLoad(this, EventArgs.Empty);

        }
        public virtual TView GetSelected()
        {
            var ind = PgmGrid.GetSelectedRowIndex();
            if (GridList.Count > ind)
                return GridList[ind].Object;
            else
                return default(TView);
        }
        public virtual void SetSelected(TView item)
        {
            //TODO:arrumar
            //GridList[PgmGrid.GetSelectedRowIndex()] = item;
        }
        public virtual object GetSelectedModel()
        {
            throw new Exception("This type of grid dont have a defined model");
        }

        public object GetSelectedId()
        {
            var item = GridList[PgmGrid.GetSelectedRowIndex()];

            var keyValue = item.Object.GetKeyAtributteValue();

            if (keyValue == null)
                throw new Exception("A view não tem uma key definida");

            return keyValue;
        }
        public int Count()
        {
            return GridList.Count;
        }
        public void RunFirstMenuItem()
        {
            MountMenus();
            var menus = MenuContext.Items;

            if (menus.Count == 0)
                return;

            menus[0].PerformClick();
        }
        object IGridController.GetSelected()
        {
            return GetSelected();
        }
        public virtual Task<IOperationResult> TryDelete(object id)
        {
            throw new NotImplementedException();
        }
        public virtual Task<IOperationResult> TryInativate(object id)
        {
            throw new NotImplementedException();
        }
        public virtual void Dispose()
        {
            MenuSelection.Dispose();
            foreach (var item in Disposables)
                item.Dispose();
        }
        public void RegisterDispose(IDisposable itemToDispose)
        {
            Disposables.Add(itemToDispose);
        }
        /// <summary>
        /// Carrega as colunas da grid a partir dos atributos da View.
        /// </summary>
        protected void GetColumnsFromAttributes()
        {
            Columns = new List<PgmColumn>();
            foreach (var prop in typeof(TView).GetProperties())
            {
                var modelAttributes = prop.GetCustomAttributes(typeof(PgmColumn), false);
                if (modelAttributes.Any())
                {
                    var gHead = modelAttributes.First() as PgmColumn;
                    gHead.PropertyName = prop.Name;
                    Columns.Add(gHead);
                }
            }
            Columns = Columns.OrderBy(i => i.HeaderOrder).ToList();

            if (Columns.Count != 0)
                return;

            // se nao estiver configurado nenhum gridheader, coloca a as propriedades do obj
            foreach (var prop in typeof(TView).GetProperties())
                Columns.Add(new PgmColumn
                {
                    PropertyName = prop.Name,
                    DisplayText = prop.Name
                });
        }
        /// <summary>
        /// Ordena a Grid usando uma coluna.
        /// </summary>
        /// <param name="nullableIndex">Coluna de ordenação. Se for nulo, refaz a ultima reordenação.</param>
        protected void OrderByColumn(int? nullableIndex = null)
        {
            int index;
            Tuple<int, ListSortDirection> newOrdering;
            if (nullableIndex == null)
            {
                if (LastOrdering == null)
                    return;

                index = LastOrdering.Item1;

                newOrdering = LastOrdering.Item2 == ListSortDirection.Ascending
                    ? new Tuple<int, ListSortDirection>(index, ListSortDirection.Ascending)
                    : new Tuple<int, ListSortDirection>(index, ListSortDirection.Descending);
            }
            else
            {
                index = nullableIndex.Value;
                newOrdering = LastOrdering == null
                    ? new Tuple<int, ListSortDirection>(index, ListSortDirection.Ascending)
                    : LastOrdering.Item1 == index && LastOrdering.Item2 == ListSortDirection.Ascending
                        ? new Tuple<int, ListSortDirection>(index, ListSortDirection.Descending)
                        : new Tuple<int, ListSortDirection>(index, ListSortDirection.Ascending);
            }
            var property = TypeDescriptor.GetProperties(typeof(TView)).Find(PgmGrid.GetColumns()[index].DataPropertyName, false);
            GridList.ApplySort(property, newOrdering.Item2);
            if (IsNested)
                Dummy();
            if (IsNested && NestingComparer != null)
                GridList.ApplySort(NestingComparer);
            PgmGrid.GetColumns()[index].HeaderCell.SortGlyphDirection = (SortOrder)newOrdering.Item2 + 1;
            LastOrdering = newOrdering;
        }

        private void PgmGrid_FilterTextChanged(object sender, KeyEventArgs e)
        {
            var cols = Columns.Select(i => i.PropertyName);
            Properties = new List<PropertyDescriptor>();
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(typeof(TView)))
                if (cols.Contains(prop.Name))
                    Properties.Add(prop);

            var filter = PgmGrid.FilterText;
            GridList.ApplyFilter(FilterByTextBox);
        }

        private bool FilterByTextBox(TView model)
        {
            if (IsNested && !DoNestingFilter(model))
                return false;

            foreach (var prop in Properties)
            {
                var val = prop.GetValue(model);
                if (val == null)
                    continue;
                if (val.ToString().IndexOf(PgmGrid.FilterText, StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;
            }
            return false;
        }

        protected abstract bool DoNestingFilter(TView model);
        protected abstract void Dummy();

        /// <summary>
        /// Adiciona uma regra de formatação à Grid.
        /// </summary>
        /// <param name="format">Formatação a ser aplicada.</param>
        /// <param name="rule">Regra a ser testada.</param>
        public void AddFormat(IModelFormat format, Func<TView, int, string, bool> rule)
        {
            Format.Add(format, rule);
        }

        //TODO: Verificar utilidade e descrever uso.
        public ToolStripItem GetInativeMenuItem()
        {
            return MenuContext.Items[MenuContext.Items.Count - 3];
        }
        /// <summary>
        /// Retorna a lista usada pela Grid.
        /// </summary>
        /// <typeparam name="T">Tipo da lista.</typeparam>
        /// <returns>A lista usada pela Grid.</returns>
        public IList<T> GetList<T>()
        {
            return GridList as IList<T> ?? ((IEnumerable<T>)GridList).ToList();
        }
        /// <summary>
        /// Retorna a lista usada pela Grid.
        /// </summary>
        /// <typeparam name="T">Tipo da lista.</typeparam>
        /// <returns>A lista usada pela Grid.</returns>
        public IEnumerable<TView> GetList()
        {
            return GetList<TView>();
        }
        /// <summary>
        /// Carrega a lista de dados como BindingList.
        /// </summary>
        protected async Task GetBindingListAsync()
        {
            var result = await GetForGridAsync();
            var list = await Task.Run(() => result.ToList());
            GridList = new BindingListView<TView>(list);
        }
        /// <summary>
        ///     Copia as células selecionadas para o clipboard.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Evento.</param>
        private void CopyToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(PgmGrid.GetClipboardContent(), true);
        }
        #endregion

        #region Context Menu
        public virtual void AddMenu(Dictionary<string, Action> theMenu)
        {
            foreach (var item in theMenu)
                if (item.Key == "-")
                    ContextMenuResolver.Add(new ContextMenuConfig(e => "-", () => { }));
                else
                    ContextMenuResolver.Add(new ContextMenuConfig(e => item.Key, item.Value));
        }
        public virtual void AddMenu(Dictionary<Func<TView, string>, Action> theMenu)
        {
            foreach (var item in theMenu)
                if (item.Key(default(TView)) == "-")
                    ContextMenuResolver.Add(new ContextMenuConfig(e => "-", () => { }));
                else
                    ContextMenuResolver.Add(new ContextMenuConfig(item.Key, item.Value));
        }
        public virtual void AddMenu(string name, Action method, bool emptyGrid = false)
        {
            ContextMenuResolver.Add(new ContextMenuConfig((e) => name, method) { ShowEmpty = emptyGrid });
        }
        /// <summary>
        ///     Adiciona um novo menu de contexto
        /// </summary>
        /// <param name="name">Nome de exibição</param>
        /// <param name="method">Action que será executada</param>
        /// <param name="icon">Icone que irá exibir</param>
        /// <param name="emptyGrid">Indice se deve aparecer se a grid estiver vazia</param>
        public void AddMenu(string name, Action method, Bitmap icon, bool emptyGrid = false)
        {
            ContextMenuResolver.Add(new ContextMenuConfig((e) => name, method, icon) { ShowEmpty = emptyGrid });
        }
        public void AddMenu(Func<TView, string> NameResolver, Action tMethod, Bitmap tIcon)
        {
            ContextMenuResolver.Add(new ContextMenuConfig(NameResolver, tMethod, tIcon));
        }
        public void InsertMenu(string name, Action method, Bitmap icon, int index)
        {
            ContextMenuResolver.Insert(index, new ContextMenuConfig((e) => name, method, icon));
        }
        public void InsertMenu(Func<TView, string> name, Action method, Bitmap icon, int index)
        {
            ContextMenuResolver.Insert(index, new ContextMenuConfig(name, method, icon));
        }
        public bool HasMenus()
        {
            return ContextMenuResolver.Count > 0;
        }
        public void InsertAsyncMenu(string tName, Func<Task> tMethod, Bitmap tIcon, int index)
        {
            ContextMenuResolver.Insert(index, new ContextMenuConfig((e) => tName, async () => await tMethod?.Invoke(), tIcon));
        }
        public void InsertAsyncMenu(Func<TView, string> tName, Func<Task> tMethod, Bitmap tIcon, int index)
        {
            ContextMenuResolver.Insert(index, new ContextMenuConfig(tName, async () => await tMethod?.Invoke(), tIcon));
        }
        public void InsertAsyncMenu(Func<object, string> tName, Func<Task> tMethod, Bitmap tIcon, int index)
        {
            ContextMenuResolver.Insert(index, new ContextMenuConfig((e) => tName?.Invoke(e), async () => await tMethod?.Invoke(), tIcon));
        }
        #endregion

        #region Eventos
        private void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grade = sender as DataGridView;
            if (grade == null)
                return;

            var col = e.ColumnIndex;
            var row = e.RowIndex;

            if (col < 0 || row < 0 || row >= GridList.Count)
                return;

            var colName = grade.Columns[col].Name;
            var model = GridList[row];

            var formats = Format.GetFormats(model.Object, row, colName);

            foreach (var f in formats)
            {
                var cel = e.CellStyle;
                cel.ForeColor = f.ForeColor ?? cel.ForeColor;
                cel.BackColor = f.BackColor ?? cel.BackColor;

                var style = cel.Font.Style;
                var family = f.FontFamily ?? cel.Font.FontFamily;
                var size = f.Size ?? cel.Font.SizeInPoints;

                if (f.Bold.HasValue && !style.HasFlag(FontStyle.Bold))
                    style |= FontStyle.Bold;

                if (f.Italic.HasValue && !style.HasFlag(FontStyle.Italic))
                    style |= FontStyle.Italic;

                if (f.Strikeout.HasValue && !style.HasFlag(FontStyle.Strikeout))
                    style |= FontStyle.Strikeout;

                if (f.Underline.HasValue && !style.HasFlag(FontStyle.Underline))
                    style |= FontStyle.Underline;

                cel.Font = new Font(family, size, style);
            }
        }
        private void Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (F4Mode)
            {
                Value = GetSelectedModel();

                var control = sender as Control ?? null;
                while (control != null && !(control is Form))
                    control = control.Parent;

                if (control != null)
                    (control as Form).Hide();

                return;
            }

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (IsNested)
                ToggleNestedVisibility(e);
            else
                RunFirstMenuItem();
        }

        protected abstract void ToggleNestedVisibility(DataGridViewCellMouseEventArgs eventArgs);

        private void Grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (PgmGrid.GetRows().Count == 0)
                return;

            if (e.Button == MouseButtons.Left && PgmGrid.IsSortable)
                OrderByColumn(e.ColumnIndex);

            if (e.Button == MouseButtons.Right)
            {
                var frozen = !PgmGrid.GetColumns()[e.ColumnIndex].Frozen;
                for (int i = e.ColumnIndex; i >= 0; i--)
                    PgmGrid.GetColumns()[i].Frozen = frozen;

                foreach (DataGridViewColumn item in PgmGrid.GetColumns())
                {
                    item.HeaderText = item.HeaderText.Replace("*", "");
                    if (item.Frozen)
                        item.HeaderText = "*" + item.HeaderText;
                }
            }
        }
        private void PgmGrid_GridSelectedRightMouseClick(object sender, MouseEventArgs e)
        {
            MenuSelection?.Show(PgmGrid.Grid, e.Location);
        }
        private void PgmGrid_GridNotSelectedRightMouseClick(object sender, MouseEventArgs e)
        {
            var hitLocation = PgmGrid.Grid.HitTest(e.X, e.Y);
            MountMenus();
            if (MenuContext != null && hitLocation.RowIndex != -1)
                MenuContext.Show(PgmGrid.Grid, e.Location);
            if (MenuEmptyGrid != null && hitLocation.RowIndex == -1 && hitLocation.ColumnIndex == -1)
                MenuEmptyGrid.Show(PgmGrid.Grid, e.Location);
        }
        private void MountMenus()
        {
            MenuEmptyGrid = new PragmaContextMenu();
            MenuContext = new PragmaContextMenu();

            foreach (var item in ContextMenuResolver)
            {
                MenuContext.AddMenu(item.Caption, GetSelected, item.Method, item.Ico);

                if (item.ShowEmpty)
                    MenuEmptyGrid.AddMenu(item.Caption, GetSelected, item.Method, item.Ico);
            }
        }

        public void AddMenuSeparator()
        {
            ContextMenuResolver.Add(new ContextMenuConfig((e) => "-", () => { }));
        }

        public void AddMenuSeparator(int index)
        {
            ContextMenuResolver.Insert(index, new ContextMenuConfig((e) => "-", () => { }));
        }

        public void SetSelectedPosition(int pos)
        {
            PgmGrid.SetSelectedRow(pos);
        }
        #endregion

        class ContextMenuConfig
        {
            public Func<TView, string> Caption { get; set; }
            public Action Method { get; set; }
            public Bitmap Ico { get; set; }
            public bool ShowEmpty { get; set; }

            public ContextMenuConfig(Func<TView, string> caption, Action method, Bitmap icon = null)
            {
                Method = method;
                Caption = caption;
                Ico = icon;
            }
        }
    }
}