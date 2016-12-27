﻿using Pragma.Core;
using Pragma.Excel;
using Pragma.Extensions;
using Pragma.Forms.Controls;
using Pragma.Forms.Controls.Controls;
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


        public IList<TView> GridList { get; set; }

        public IList<IDisposable> Disposables
                        = new List<IDisposable>();

        protected PragmaDataGrid _grid = null;

        public int QtdTopResult { get; set; } = 100;

        public IModelFormatRule<TView> Format { get; set; }
                        = new ModelFormatRule<TView>();

        PragmaContextMenu MenuContext { get; set; } = new PragmaContextMenu();// Menu de Contexto
        PragmaContextMenu MenuSelection { get; set; } = new PragmaContextMenu();// Menu da seleção do grid
        PragmaContextMenu MenuEmptyGrid { get; set; } = new PragmaContextMenu();// Menu da seleção do grid


        public abstract void SetPredicate(Expression<Func<TView, bool>> predicate);

        public void ExportToExcel(IExcelTool tool, string file)
        {
            tool.ExportFromList(GetList<TView>(), file);
        }

        public AbstractGridController()
        {

            // Menu da seleção do grid
            MenuSelection = new PragmaContextMenu();
            var item = new ToolStripMenuItem
            {
                Text = Messages.Copy,
                Image = BaseIcons.copy
            };
            item.Click += new EventHandler(CopyToClipboard);
            MenuSelection.Items.Add(item);



        }

        public virtual async Task Use(PragmaDataGrid grid)
        {
            _grid = grid;

            _grid.SetMenus(MenuContext, MenuSelection, MenuEmptyGrid);

            _grid.GridCellPainting += Grid_CellPainting;


            if (_grid.UseOddRowColor)
            {
                AddFormat(
                        new ModelFormat()
                        {
                            BackColor = Color.LightGray
                        },
                        (m, i, p) => i % 2 != 0

                    );

            }


            await Refresh();

        }


        public void AddFormat(IModelFormat format, Func<TView, int, string, bool> rule)
        {
            Format.Add(format, rule);

        }

        public void SetSelectedPosition(Func<TView, bool> predicate)
        {
            var index = _grid.GetList<TView>().FindIndex(predicate);
            _grid.SelectRow(index);

        }

        public void SetSelectedPosition(object id)
        {
            var list = _grid.GetList<TView>();

            for (int i = 0; i < list.Count(); i++)
            {
                var _id = list[i].GetType().GetKeyValue(list[i]);

                if (id.Equals(_id))
                {
                    _grid.SelectRow(i);
                    break;
                }

            }

        }

        public virtual async Task Refresh()
        {

            if (_grid == null)
                return;


            await BindListToGrid();

            _grid.GetHeadersFromAttributes<TView>();
            _grid.GridRefresh();

        }


        #region "Context Menu "

        public virtual void AddMenu(Dictionary<string, Action> theMenu)
        {
            foreach (var item in theMenu)
            {
                if (item.Key == "-")
                    AddMenuSeparator();
                else
                    AddMenu(item.Key, item.Value);
            }
        }

        public virtual void AddMenu(string name, Action method, bool emptyGrid = false)
        {
            MenuContext.AddMenu(name, method);

            if (emptyGrid)
                MenuEmptyGrid.AddMenu(name, method);
        }


        /// <summary>
        /// Adiciona um novo menu de contexto
        /// </summary>
        /// <param name="name">Nome de exibição</param>
        /// <param name="method">Action que será executada</param>
        /// <param name="icon">Icone que irá exibir</param>
        /// <param name="emptyGrid">Indice se deve aparecer se a grid estiver vazia</param>
        public void AddMenu(string name, Action method, Bitmap icon, bool emptyGrid = false)
        {
            MenuContext.AddMenu(name, method, icon);

            if (emptyGrid)
                MenuEmptyGrid.AddMenu(name, method, icon);
        }

        /// <summary>
        /// Adiciona todos os itens de outros menu
        /// </summary>
        /// <param name="listMenu">Lista de itens</param>
        public void AddRangeMenu(ToolStripItem[] listMenu)
        {
            MenuContext.Items.AddRange(listMenu);
        }

        public void AddMenuSeparator()
        {
            MenuContext.AddSeparator();
        }


        public void AddMenuSeparator(int index)
        {
            MenuContext.AddSeparator(index);
        }
        public void InsertMenu(string name, Action method, Bitmap icon, int index)
        {
            MenuContext.InsertMenu(name, method, icon, index);
        }


        public bool HasMenus()
        {
            return MenuContext.Items.Count > 0;
        }


        public void InsertAsyncMenu(string tName, Func<Task> tMethod, Bitmap tIcon, int index)
        {
            MenuContext.InsertAsyncMenu(tName, tMethod, tIcon, index);
        }


        #endregion

        public virtual TView GetSelected()
        {
            return _grid.GetSelectRow<TView>();
        }


        public object GetSelectedId()
        {
            var item = _grid.GetSelectRow<TView>();

            var keyValue = item.GetType().GetKeyValue(item);

            if (keyValue == null)
                throw new Exception("The view dont have a defined Key");

            return keyValue;
        }

        public int Count()
        {
            return _grid.GetList<object>().Count();
        }


        public void RunFirstMenuItem()
        {
            var menus = MenuContext.Items;

            if (menus.Count == 0)
                return;


            menus[0].PerformClick();

        }


        private async Task BindListToGrid()
        {
            var result = await GetForGrid();
            GridList = result.ToList();
            var bindingList = new BindingList<TView>(result.ToList());
            var source = new BindingSource(bindingList, null);
            _grid.DataSource = source;


        }

        protected abstract Task<IEnumerable<TView>> GetForGrid();





        public ToolStripItem GetInativeMenuItem()
        {
            return MenuContext.Items[MenuContext.Items.Count - 3];
        }

        /// <summary>
        /// Copia as células selecionadas para o clipboard.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Evento.</param>
        private void CopyToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(_grid.GetClipboardContent(), true);
        }

        object IGridController.GetSelected()
        {
            return GetSelected();
        }

        public virtual IOperationResult TryDelete(object id)
        {
            throw new NotImplementedException();
        }

        public virtual IOperationResult TryInativate(object id)
        {
            throw new NotImplementedException();
        }

        public virtual void Dispose()
        {
            foreach (var item in Disposables)
                item.Dispose();
        }

        public void RegisterDispose(IDisposable itemToDispose)
        {
            Disposables.Add(itemToDispose);
        }



        public IList<T> GetList<T>()
        {
            return _grid.GetList<T>();
        }


        private void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grade = sender as DataGridView;
            var col = e.ColumnIndex;
            var row = e.RowIndex;


            if (col < 0 || row < 0 || row >= GridList.Count())
                return;

            var colName = grade.Columns[e.ColumnIndex].Name;
            var model = GridList[row];


            var formats = Format.GetFormats(model, row, colName);

            foreach (var f in formats)
            {
                var cel = e.CellStyle;
                cel.ForeColor = f.ForeColor ?? cel.ForeColor;
                cel.BackColor = f.BackColor ?? cel.BackColor;

                FontStyle style = cel.Font.Style;
                FontFamily family = f.FontFamily ?? cel.Font.FontFamily;
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


    }


}