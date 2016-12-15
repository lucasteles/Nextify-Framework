using Pragma.Core;
using Pragma.Extensions;
using Pragma.Forms.Controls.Attributes;
using Pragma.Forms.Controls.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Pragma.Forms.Controls.Controls
{
    public partial class PragmaDataGrid : PragmaUserControl
    {

        public bool UseOddRowColor { get; set; } = true;

        SortOrder OrderDir { get; set; } = SortOrder.None; // Tipo da ordenação
        int IndexOrderCol { get; set; } // Controle da coluna que está ordenada
        int IndexFrozenCol { get; set; }
        IList<PgmHeader> ListHeader { get; set; } = new List<PgmHeader>(); // Lista de Layout das colunas

        bool IsMouseButtonPressed { get; set; } // Indica se o botão do mouse está pressionado
        DataGridViewCell MouseDownCell { get; set; } // Celula onde o botão do mouse foi apertado

        PragmaContextMenu MenuContext { get; set; } = new PragmaContextMenu();// Menu de Contexto
        PragmaContextMenu MenuSelection { get; set; } = new PragmaContextMenu();// Menu da seleção do grid
        PragmaContextMenu MenuEmptyGrid { get; set; } = new PragmaContextMenu();// Menu da seleção do gri



        public object DataSource { get { return Grid.DataSource; } set { Grid.DataSource = value; } }


        public PragmaDataGrid()
        {
            InitializeComponent();

            // Padrão
            IsSortable = false;
            txtFilter.Visible = TextFilter;
            Grid.MultiSelect = false;
            Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;

        }

        #region  Metodos

        public void SetMenus(PragmaContextMenu context, PragmaContextMenu selection, PragmaContextMenu empty)
        {
            MenuContext = context;
            MenuSelection = selection;
            MenuEmptyGrid = empty;
        }


        public void SelectRow(int index)
        {
            Grid.Rows[index].Selected = true;
        }

        public DataObject GetClipboardContent()
        {
            return Grid.GetClipboardContent();
        }

        /// <summary>
        /// Propriedade indica se as colunas podem ser ordenadas
        /// </summary>
        [Description("Propriedade indica se as colunas podem ser ordenadas")]
        public bool IsSortable { get; set; }
        /// <summary>
        /// Propriedade indica se a grid está vazia
        /// </summary>
        [Description("Propriedade indica se a grid está vazia")]
        public bool IsEmpty { get { return false; } }

        /// <summary>
        /// Propriedade indica se deve fazer auto ajuste do tamanho das colunas
        /// </summary>
        [Description("Propriedade indica se deve fazer auto ajuste do tamanho das colunas")]
        public bool IsAutoSizeColumns { get; set; } = true;

        /// <summary>
        /// Propriedade indica se deve exibir a text para filtar coluna digitando
        /// </summary>
        [Description("Propriedade indica se deve exibir a text para filtar coluna digitando")]
        public bool TextFilter { get { return txtFilter.Visible; } set { txtFilter.Visible = value; } }

        /// <summary>
        /// Propriedade indica qual campo é filtrado usando a textbox de filtro
        /// </summary>
        [Description("Propriedade indica qual campo é filtrado usando a textbox de filtro")]
        public string TextFilterField { get; set; }

        /// <summary>
        /// Propriedade indica quais campos são filtrados usando a textbox de filtro.
        /// </summary>
        [Description("Propriedade indica quais campos são filtrados usando a textbox de filtro")]
        public string[] TextFilterArray { get; set; }

        private Func<object, IComparable> NestedPrimaryKey { get; set; }
        private Func<object, IComparable> NestedForeignKey { get; set; }
        private bool NestedUseDescendingOrder { get; set; }
        private static int NestedGridGradient = 40;

        public bool IsNested { get; private set; }




        /// <summary>
        /// Usando uma lista de Layout, configura todas as colunas
        /// </summary>
        /// <param name="oList">Lista da classe PGM.Controls.PgmHeader</param>
        public void SetHeader(IList<PgmHeader> oList)
        {
            Grid.Columns.Clear();
            Grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            ListHeader = oList;
            // Adiciona no filtro da lista de campos
            TextFilterArray = ListHeader.ToList().Select(i => i.FieldName).ToArray();

            foreach (PgmHeader oItem in ListHeader)
            {
                var oCol = new DataGridViewColumn();
                Grid.AutoGenerateColumns = false;
                switch (oItem.Control)
                {
                    case ControlType.TextBox:
                        oCol = new DataGridViewTextBoxColumn();
                        oCol.ReadOnly = true;
                        break;
                    case ControlType.TextBoxEdit:
                        oCol = new DataGridViewTextBoxColumn();
                        break;
                    case ControlType.CheckBox:
                        oCol = new DataGridViewCheckBoxColumn();
                        oCol.HeaderCell = new PgmDataGridViewCheckBoxHeaderCell();
                        oCol.ValueType = typeof(bool);
                        break;
                    case ControlType.ComboBox:
                        oCol = new DataGridViewComboBoxColumn();
                        break;
                    default:
                        break;
                }

                oCol.DataPropertyName = oItem.FieldName;
                oCol.HeaderText = oItem.ColumnName;
                oCol.Name = oItem.FieldName;
                oCol.DefaultCellStyle.NullValue = oItem.NullValue;
                oCol.DefaultCellStyle.Format = oItem.Format;

                if (oItem.ColumnSize > 0)
                    oCol.Width = oItem.ColumnSize;
                if (oItem.ColumnMinSize > 0)
                    oCol.Width = Math.Max(oItem.ColumnMinSize, oCol.Width);
                if (oItem.ColumnMaxSize > 0)
                    oCol.Width = Math.Min(oItem.ColumnMaxSize, oCol.Width);
                oCol.SortMode = DataGridViewColumnSortMode.Programmatic;

                Grid.Columns.Add(oCol);
            }
        }


        public void GetHeadersFromAttributes<T>()
        {
            var headers = new List<PgmHeader>();
            foreach (var prop in typeof(T).GetProperties())
            {
                var gh = prop.GetCustomAttributes(typeof(PgmHeader), false);

                if (gh.Count() > 0)
                {
                    var gHead = gh.First() as PgmHeader;
                    gHead.FieldName = prop.Name;
                    headers.Add(gHead);

                }
            }
            headers.OrderBy(i => i.HeaderOrder);
            // se nao estiver configurado nenhum gridheader, coloca a as propriedades do obj
            if (headers.Count == 0)
                foreach (var prop in typeof(T).GetProperties())
                {
                    headers.Add(new PgmHeader
                    {
                        FieldName = prop.Name,
                        ColumnName = prop.Name,
                        Control = ControlType.TextBox
                    });
                }

            SetHeader(headers);
        }





        public IList<T> GetList<T>() => (DataSource as BindingSource).Cast<T>().ToList();


        /// <summary>
        /// Retorna os Headers da Grade
        /// </summary>
        /// <returns>A lista de Headers</returns>
        public IList<PgmHeader> GetHeaders()
        {
            return ListHeader;
        }



        /// <summary>
        /// Foca no filtro do Grid.
        /// </summary>
        public void FocusOnFilter()
        {
            txtFilter.Focus();
        }


        /// <summary>
        /// Redimensiona as colunas da Grid se AutoSize for true.
        /// </summary>
        public void ResizeColumns()
        {
            if (IsAutoSizeColumns)
            {
                var lastRow = Grid.Columns[Grid.ColumnCount - 1];
                if (lastRow.MinimumWidth <= 5) lastRow.MinimumWidth = lastRow.Width;
                Grid.AutoResizeColumns();
                if (!lastRow.Frozen)
                    lastRow.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ToggleVisibleRows(int rowIndex, bool visible)
        {
            var selectedRow = Grid.Rows[rowIndex];
            var color = selectedRow.DefaultCellStyle.BackColor;
            var value = NestedPrimaryKey?.Invoke(selectedRow.DataBoundItem);

            foreach (DataGridViewRow row in Grid.Rows)
            {
                var fkValue = NestedForeignKey?.Invoke(row.DataBoundItem);
                if (fkValue.CompareTo(value) == 0)
                {
                    row.Visible = visible;
                    row.DefaultCellStyle.BackColor = Color.FromArgb(color.R == 0 ? 255 - NestedGridGradient : color.R - NestedGridGradient,
                                                                    color.G == 0 ? 255 - NestedGridGradient : color.G - NestedGridGradient,
                                                                    color.B == 0 ? 255 - NestedGridGradient : color.B - NestedGridGradient);
                    if (!visible)
                        ToggleVisibleRows(row.Index, visible);
                }
            }
        }


        private void PaintRows(IComparable root, bool doHideNested)
        {
            var currencyManager = (CurrencyManager)BindingContext[Grid.DataSource];
            currencyManager.SuspendBinding();

            foreach (DataGridViewRow row in Grid.Rows)
                row.DefaultCellStyle.BackColor = PragmaColor.VermelhoError;

            PaintChilds(root, PragmaColor.Branco, doHideNested, true);

            currencyManager.ResumeBinding();
        }
        private void PaintChilds(IComparable root, Color color, bool doHideNested, bool visible = false)
        {
            foreach (DataGridViewRow row in Grid.Rows)
            {
                var value = NestedForeignKey(row.DataBoundItem);

                if (value.CompareTo(root) == 0)
                {
                    row.DefaultCellStyle.BackColor = color;
                    row.Visible = !doHideNested || visible;
                    PaintChilds(NestedPrimaryKey(row.DataBoundItem),
                                Color.FromArgb(color.R - NestedGridGradient,
                                               color.G - NestedGridGradient,
                                               color.B - NestedGridGradient),
                                doHideNested);
                }

            }

        }

        private void AddSubItems(IComparable primaryKey, ref int index, List<object> list)
        {
            var subList = list.Where(i => NestedForeignKey(i).CompareTo(primaryKey) == 0).ToList();
            foreach (var item in subList)
            {
                list.Remove(item);
                list.Insert(index++, item);
                AddSubItems(NestedPrimaryKey(item), ref index, list);
            }
        }

        private void DoNestedGrid(bool doHideNested = true)
        {
            var a = Grid.DataSource as BindingSource;
            var lista = a.List.Cast<object>().ToList();
            if (lista.Count == 0)
                return;
            //Valor da raiz da árvore
            var root = NestedForeignKey(lista.First());

            lista.ForEach(i =>
            {
                var value = NestedForeignKey(i);
                var comparison = value.CompareTo(root);
                if ((comparison < 0 && !NestedUseDescendingOrder) ||
                    (comparison > 0 && NestedUseDescendingOrder))
                    root = value;
            });

            var index = 0;
            AddSubItems(root, ref index, lista);

            //ControlCursor.SetList((IList)lista);
            var bs = new BindingSource();
            bs.ResetBindings(false);
            bs.DataSource = lista;
            Grid.DataSource = bs;

            PaintRows(root, doHideNested);
        }

        public void SetNestedProperties(Expression<Func<object, IComparable>> primaryKey, Expression<Func<object, IComparable>> foreignKey, bool useDescendingOrder = false)
        {
            if (primaryKey == null || foreignKey == null)
                return;
            NestedPrimaryKey = primaryKey.Compile();
            NestedForeignKey = foreignKey.Compile();
            NestedUseDescendingOrder = useDescendingOrder;
            IsNested = true;
        }

        /// <summary>
        /// Define por qual coluna os dados devem ser ordenados
        /// </summary>
        /// <param name="tCol">Nome do campo na lista</param>
        public void SetColumnOrder(string tCol)
        {
            // Se a coluna existir, a define como a coluna de ordenação
            if (Grid.Columns[tCol].GetType() == typeof(DataGridViewColumn))
                IndexOrderCol = Grid.Columns[tCol].Index;
        }


        /// <summary>
        /// Retorna uma DataGridViewRow da linha selecionada
        /// </summary>
        public DataGridViewRow GetSelectDataViewRow()
        {
            return Grid.CurrentRow ?? new DataGridViewRow();
        }


        /// <summary>
        /// Retorna o objeto do tipo selecionado
        /// </summary>
        public virtual T GetSelectRow<T>()
        {
            var Retorno = default(T);
            var nIndex = 0;
            IList<T> oList;

            if (Grid.CurrentRow != null)
            {
                nIndex = Grid.CurrentRow.Index;
                oList = GetList<T>();
                Retorno = oList[nIndex];
            }


            return Retorno;
        }


        /// <summary>
        /// Retorna as linhas da Grid
        /// </summary>
        public DataGridViewRowCollection GetRows()
        {
            return Grid.Rows;


        }
        /// <summary>
        /// Retorna as linhas da Grid
        /// </summary>
        public DataGridViewColumnCollection GetColumns()
        {
            return Grid.Columns;
        }
        /// <summary>
        /// Atualiza a céula selecionada na grid.
        /// </summary>
        public bool RefreshEdit()
        {
            return Grid.RefreshEdit();
        }

        /// <summary>
        /// Retorna o index da linha selecionada
        /// </summary>
        public int GetSelectRowIndex()
        {
            return (Grid.CurrentRow != null) ? Grid.CurrentRow.Index : 0;
        }

        /// <summary>
        /// Retorna o valor da coluna como Object
        /// </summary>
        /// <param name="tCol">Nome da coluna na lista</param>
        public object GetSelectRowColumn(string tCol)
        {
            var list = (IEnumerable)GetList<object>();
            var elementType = list.GetType().GetGenericArguments()[0];
            var displayValues = list.Cast<object>()
                                    .Select(v => elementType.GetProperty(tCol).GetValue(v, null))
                                    .ToList();

            if (displayValues.Count == 0)
                return null;

            return displayValues[GetSelectRowIndex()];
        }


        /// <summary>
        /// Atualizar as configurações da Grid
        /// </summary>
        public void GridRefresh(bool doHideNested = true)
        {
            // Exibe o numero de registros
            var list = GetList<object>();
            lblNrRegistros.Text = list.Count().StrZero(8);

            if (list != null && !(list.Count() == 0))
            {
                var i = 0;
                foreach (object item in list)
                {
                    if (Grid.Rows.Count > i)
                        //DoPgmValid(item, Grid.Rows[i]);
                        i++;
                }

                foreach (DataGridViewColumn item in Grid.Columns)
                {
                    if (item.Index == IndexOrderCol)
                        item.HeaderCell.SortGlyphDirection = OrderDir;
                    else
                        item.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }

            if (IsNested)
                DoNestedGrid(doHideNested);

            Grid.Refresh();

        }

        /// <summary>
        /// Limpar todos os registros da grade
        /// </summary>
        public void Clear()
        {
            txtFilter.Text = "";
            var bs = new BindingSource();
            bs.ResetBindings(false);
            bs.DataSource =
            Grid.DataSource = bs;
            GridRefresh(false);
        }










        #endregion

        #region Eventos

        /// <summary>
        /// Executado apoós um click duplo.
        /// </summary>
        [Description("Executado apoós um click duplo.")]


        public event DataGridViewCellMouseEventHandler GridCellDoubleClick;
        public virtual void DoDoubleClick(object o, DataGridViewCellMouseEventArgs e) { GridCellDoubleClick?.Invoke(o, e); }






        private void Grid_MouseClick(object sender, MouseEventArgs e)
        {
            var hitLocation = Grid.HitTest(e.X, e.Y);
            var selected = false;
            if (e.Button == MouseButtons.Right)
            {
                if (hitLocation.RowIndex >= 0)
                {
                    var cell = Grid.Rows[hitLocation.RowIndex].Cells[hitLocation.ColumnIndex];

                    if (Grid.MultiSelect && cell.Selected)
                    {
                        //Mostrar Menu de Seleção
                        MenuSelection.Show(Grid, e.Location);
                        selected = true;
                    }
                    else
                    {
                        //Selecionar linha inteira
                        Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        Grid.MultiSelect = false;
                        cell.Selected = true;
                    }
                }
                // se não exibiu o menu de seleção, exibe o menu normal e força sempre exibir se a grid estiver vazia
                if (MenuContext != null && !selected && hitLocation.RowIndex != -1)
                    MenuContext.Show(Grid, e.Location);
                if (MenuContext != null && !selected &&
                        hitLocation.RowIndex == -1 && hitLocation.ColumnIndex == -1)
                    MenuEmptyGrid.Show(Grid, e.Location);

            }
        }



        #endregion

        private void Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DoDoubleClick(sender, e);
        }


        public event DataGridViewCellPaintingEventHandler GridCellPainting;
        public virtual void DoCellPainting(object o, DataGridViewCellPaintingEventArgs e) { GridCellPainting?.Invoke(o, e); }
        private void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DoCellPainting(sender, e);
        }
    }
}
