using Pragma.Core;
using Pragma.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls
{
    public interface IGridController : IDisposeContainer
    {
        int QtdTopResult { get; set; }

        bool FilterInative { get; set; }

        Task UseAsync(PragmaDataGrid grid);

        Task RefreshAsync();

        void AddMenu(Dictionary<string, Action> theMenu);

        void AddMenu(string name, Action method, bool emptyGrid = false);

        void AddMenu(string name, Action method, Bitmap icon, bool emptyGrid = false);

        void InsertMenu(string tName, Action tMethod, Bitmap tIcon, int index);

        void InsertAsyncMenu(string tName, Func<Task> tMethod, Bitmap tIcon, int index);

        void AddMenuSeparator();

        void AddMenuSeparator(int index);

        bool HasMenus();

        object GetSelected();

        bool F4Mode { get; set; }

        object GetSelectedId();

        int Count();

        IList<T> GetList<T>();

        void RunFirstMenuItem();

        Task<IOperationResult> TryDelete(object id);

        Task<IOperationResult> TryInativate(object id);

        void SetSelectedPosition(object id);

        void ExportToExcel(IExcelTool tool, string file);

        void InsertAsyncMenu(Func<object, string> tName, Func<Task> tMethod, Bitmap tIcon, int index);

        object GetSelectedModel();

        object Value { get; set; }

        event EventHandler StartLoad;
        event EventHandler EndLoad;
    }

    public interface IGridController<TView> : IGridController
    {
        void SetPredicate(Expression<Func<TView, bool>> predicate);

        new TView GetSelected();

        void SetSelected(TView item);

        void InsertAsyncMenu(Func<TView, string> tName, Func<Task> tMethod, Bitmap tIcon, int index);

        void InsertMenu(Func<TView, string> name, Action method, Bitmap icon, int index);

        void SetSelectedPosition(Func<TView, bool> predicate);

        void SetSelectedPosition(int pos);

        IEnumerable<TView> GetList();
    }
}