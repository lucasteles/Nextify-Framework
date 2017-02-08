using Equin.ApplicationFramework;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Core;
using Nextify.Forms.Controls.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Nextify.Forms.Controls
{
    public partial class NextifyDataGrid : NextifyUserControl, INextifyDataGrid
    {
        #region Propriedades
        /// <summary>
        /// Cor das linhas ímpar
        /// </summary>
        public Color OddRowColor { get; set; } = ColorTool.CinzaLinhaDataGrid;

        public Color SelectionBackColor { get; set; } = ColorTool.MetroRed;
        /// <summary>
        /// Indica se o botão esquerdo do mouse está pressionado.
        /// </summary>
        private bool IsMouseButtonPressed { get; set; }
        /// <summary>
        /// Célula onde o botão do mouse foi pressionado.
        /// </summary>
        private DataGridViewCell MouseDownCell { get; set; }
        /// <summary>
        /// Grid que apresenta os dados. Deve ser usado somente para adicionar eventos.
        /// </summary>
        public DataGridView Grid => grdView;
        /// <summary>
        /// Texto do conteúdo do filtro.
        /// </summary>
        public string FilterText => txtFilter.Text;
        /// <summary>
        /// Propriedade indica se deve ser feito o auto ajuste do tamanho das colunas.
        /// </summary>
        public bool IsAutoSizeColumns { get; set; } = true;
        /// <summary>
        /// Indica se deve exibir a textbox de filtro.
        /// </summary>
        public bool IsTextFilterVisible
        {
            get { return txtFilter.Visible; }
            set { txtFilter.Visible = value; }
        }
        /// <summary>
        /// Indica se a Grid será listrada.
        /// </summary>
        public bool UseOddRowColor { get; set; } = true;
        /// <summary>
        /// Indica se a Grid pode ser reordenada.
        /// </summary>
        public bool IsSortable { get; set; } = true;
        /// <summary>
        /// Indica se a Grid pode filtrado.
        /// </summary>
        public bool UseCustomFilter { get; set; } = false;
        #endregion

        #region Construtores
        public NextifyDataGrid()
        {
            InitializeComponent();
            if (DesignMode)
                return;

            // Padrão
            txtFilter.Visible = IsTextFilterVisible;
            grdView.MultiSelect = false;
            grdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            Grid.DefaultCellStyle.SelectionBackColor = SelectionBackColor;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Faz o binding de uma lista ao Grid e passa a configuração das colunas.
        /// </summary>
        /// <typeparam name="TView">Tipo da View.</typeparam>
        /// <param name="list">Lista de dados.</param>
        /// <param name="columns">Colunas da Grid</param>
        public void BindList<TView>(BindingListView<TView> list, IList<PgmColumn> columns)
        {
            if (!UseCustomFilter)
                ClearFilter();

            SetHeader(columns);
            grdView.DataSource = list;
            list.ListChanged += List_ListChanged;
            ResizeColumns();
            UpdateQuantityLabel();
        }
        /// <summary>
        ///     Usando uma lista de Layout, configura todas as colunas.
        /// </summary>
        /// <param name="headerList">Lista de colunas.</param>
        public void SetHeader(IList<PgmColumn> headerList)
        {
            grdView.Columns.Clear();
            grdView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (var header in headerList)
            {
                DataGridViewColumn col;
                grdView.AutoGenerateColumns = false;
                switch (header.Control)
                {
                    case ControlType.TextBox:
                        col = new DataGridViewTextBoxColumn { ReadOnly = true };
                        break;
                    case ControlType.TextBoxEdit:
                        col = new DataGridViewTextBoxColumn();
                        break;
                    case ControlType.CheckBox:
                        col = new DataGridViewCheckBoxColumn
                        {
                            HeaderCell = new PgmDataGridViewCheckBoxHeaderCell(),
                            ValueType = typeof(bool)
                        };
                        break;
                    case ControlType.ComboBox:
                        col = new DataGridViewComboBoxColumn();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                col.DataPropertyName = header.PropertyName;
                col.HeaderText = header.DisplayText;
                col.Name = header.PropertyName;
                col.DefaultCellStyle.NullValue = header.ValueIfNull;
                col.DefaultCellStyle.Format = header.Format;

                var newStyle = FontStyle.Regular;
                if (header.Bold) newStyle |= FontStyle.Bold;
                if (header.Italic) newStyle |= FontStyle.Italic;
                if (header.Underline) newStyle |= FontStyle.Underline;
                col.DefaultCellStyle.Font = new Font(grdView.DefaultCellStyle.Font, newStyle);

                switch (header.Alignment)
                {
                    case PgmTextAlignment.Left:
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case PgmTextAlignment.Center:
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case PgmTextAlignment.Right:
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                if (header.Control == ControlType.CheckBox)
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                col.Width = header.ColumnSize;
                col.SortMode = DataGridViewColumnSortMode.Programmatic;

                grdView.Columns.Add(col);
            }
        }
        /// <summary>
        ///     Redimensiona as colunas da Grid se AutoSize for true.
        /// </summary>
        public void ResizeColumns()
        {
            if (IsAutoSizeColumns)
            {
                var lastRow = grdView.Columns[grdView.ColumnCount - 1];
                if (lastRow.MinimumWidth <= 5) lastRow.MinimumWidth = lastRow.Width;
                grdView.AutoResizeColumns();
                if (!lastRow.Frozen)
                    lastRow.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        /// <summary>
        ///     Retorna as linhas da Grid.
        /// </summary>
        public DataGridViewRowCollection GetRows()
        {
            return grdView.Rows;
        }
        /// <summary>
        ///     Retorna as colunas da Grid.
        /// </summary>
        public DataGridViewColumnCollection GetColumns()
        {
            return grdView.Columns;
        }
        /// <summary>
        ///     Retorna o index da linha selecionada
        /// </summary>
        public int GetSelectedRowIndex()
        {
            return grdView.CurrentRow?.Index ?? 0;
        }
        /// <summary>
        /// Seleciona uma linha da grid a partir de um index.
        /// </summary>
        /// <param name="index">Index da linha.</param>
        public void SetSelectedRow(int index)
        {
            grdView.Rows[index].Selected = true;
        }
        /// <summary>
        /// Atualiza a quantidade de linhas visíveis.
        /// </summary>
        private void UpdateQuantityLabel()
        {
            var count = 0;
            foreach (DataGridViewRow row in GetRows())
                count += row.Visible ? 1 : 0;
            lblNrRegistros.Text = count.ToString();
        }
        /// <summary>
        ///     Limpa o campo de filtro
        /// </summary>
        public void ClearFilter()
        {
            txtFilter.Text = "";
        }

        public void FocusFilter()
        {
            txtFilter.Focus();
            txtFilter.SelectionStart = 0;
            txtFilter.SelectionLength = txtFilter.Text.Length;
        }

        /// <summary>
        /// Pega o conteúdo das células selecionadas.
        /// </summary>
        /// <returns>Valores formatados que representam os conteúdos das células selecionadas.</returns>
        public DataObject GetClipboardContent()
        {
            return grdView.GetClipboardContent();
        }
        #endregion

        #region Eventos
        /// <summary>
        ///     Executado apoós um click em celulas selecionadas da grid.
        /// </summary>
        [Description("Executado apoós um click em celulas selecionadas da grid.")]
        public event MouseEventHandler GridSelectedRightMouseClick;

        /// <summary>
        ///     Executado apoós um click em celulas não selecionadas da grid.
        /// </summary>
        [Description("Executado apoós um click em celulas não selecionadas da grid.")]
        public event MouseEventHandler GridNotSelectedRightMouseClick;

        /// <summary>
        ///     Executado após a alteração do campo de filtro.
        /// </summary>
        [Description("Executado após a alteração do campo de filtro.")]
        public event KeyEventHandler FilterTextChanged;

        private void List_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateQuantityLabel();
        }

        private void Grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var hitLocation = grdView.HitTest(e.X, e.Y);
            var selected = false;
            if (hitLocation.RowIndex >= 0)
            {
                var clickedCell = grdView.Rows[hitLocation.RowIndex].Cells[hitLocation.ColumnIndex];

                if (grdView.MultiSelect && clickedCell.Selected)
                {
                    //Mostrar Menu de Seleção
                    GridSelectedRightMouseClick?.Invoke(sender, e);
                    selected = true;
                }
                else
                {
                    //Selecionar linha inteira
                    grdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grdView.MultiSelect = false;
                    clickedCell.Selected = true;
                }
            }
            // se não exibiu o menu de seleção, exibe o menu normal e força sempre exibir se a grid estiver vazia
            if (!selected)
                GridNotSelectedRightMouseClick?.Invoke(sender, e);
        }

        private void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (UseOddRowColor && e.RowIndex % 2 == 0)
                e.CellStyle.BackColor = OddRowColor;
        }

        private void Grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (IsMouseButtonPressed)
            {
                grdView.MultiSelect = true;
                grdView.SelectionMode = DataGridViewSelectionMode.CellSelect;
                var startRow = Math.Min(MouseDownCell.RowIndex, e.RowIndex);
                var startCol = Math.Min(MouseDownCell.ColumnIndex, e.ColumnIndex);
                var endRow = Math.Max(MouseDownCell.RowIndex, e.RowIndex);
                var endCol = Math.Max(MouseDownCell.ColumnIndex, e.ColumnIndex);
                foreach (DataGridViewRow r in grdView.Rows)
                    foreach (DataGridViewCell c in r.Cells)
                        if (c.RowIndex >= startRow && c.RowIndex <= endRow && c.ColumnIndex >= startCol &&
                            c.ColumnIndex <= endCol)
                            c.Selected = true;
                        else
                            c.Selected = false;
            }

            if (IsSortable && e.RowIndex < 0
                && grdView.Rows.Count > 0
                && grdView.Columns[e.ColumnIndex].CellType != typeof(DataGridViewCheckBoxCell))
                grdView.Cursor = Cursors.PanSouth;
        }

        private void Grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (IsSortable && e.RowIndex < 0 && grdView.Rows.Count > 0)
                grdView.Cursor = Cursors.Default;
        }

        private void txtFilter_KeyUp(object sender, KeyEventArgs e)
        {
            if (!IsSortable)
                return;

            FilterTextChanged?.Invoke(sender, e);
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            grdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdView.MultiSelect = false;
            grdView.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void Grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || e.RowIndex < 0 || e.ColumnIndex < 0) return;

            IsMouseButtonPressed = true;
            MouseDownCell = grdView.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void Grid_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseButtonPressed = false;
        }

        private void Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'F')
                txtFilter.Focus();
        }
        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;
            if (e.RowIndex < 0)
                return;

            var col = grdView.Columns[e.ColumnIndex];

            if (col.GetType() != typeof(DataGridViewCheckBoxColumn)) return;

            IsMouseButtonPressed = false;

            grdView.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //CheckBox All
            var b = true;
            for (int i = 0; i < grdView.RowCount; i++)
            {
                var cell = (DataGridViewCheckBoxCell)grdView.Rows[i].Cells[e.ColumnIndex];
                var c = (bool)cell.Value;
                b &= c;
            }
            //grdView.RefreshEdit();
            ((PgmDataGridViewCheckBoxHeaderCell)grdView.Columns[e.ColumnIndex].HeaderCell).SetCheckBoxValue(b, e.RowIndex);
            grdView.InvalidateColumn(e.ColumnIndex);
        }
        #endregion
    }
}