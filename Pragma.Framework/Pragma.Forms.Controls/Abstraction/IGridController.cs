using Pragma.Core;
using Pragma.Excel;
using Pragma.Forms.Controls.Controls;
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

        Task Use(PragmaDataGrid grid);

        Task Refresh();

        void AddMenu(Dictionary<string, Action> theMenu);


        void AddMenu(string name, Action method, bool emptyGrid = false);

        void AddMenu(string name, Action method, Bitmap icon, bool emptyGrid = false);

        void InsertMenu(string tName, Action tMethod, Bitmap tIcon, int index);


        void InsertAsyncMenu(string tName, Func<Task> tMethod, Bitmap tIcon, int index);


        void AddMenuSeparator();

        void AddMenuSeparator(int index);

        bool HasMenus();

        object GetSelected();

        object GetSelectedId();



        int Count();

        void RunFirstMenuItem();

        IOperationResult TryDelete(object id);

        IOperationResult TryInativate(object id);

        void SetSelectedPosition(object id);


        void ExportToExcel(IExcelTool tool, string file);
    }


    public interface IGridController<TView> : IGridController
    {
        void SetPredicate(Expression<Func<TView, bool>> predicate);

        new TView GetSelected();



        void SetSelectedPosition(Func<TView, bool> predicate);


    }
}