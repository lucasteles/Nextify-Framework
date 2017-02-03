using Pragma.Abstraction;
using Pragma.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Abstraction.Forms.Controls
{
    public interface IPragmaComboBox :  IControl
    {
                         
        event EventHandler ValueGet;
        event EventHandler ValueSet;

        void BindList<TView>(IList<TView> list);
        void DoValueGet(object sender, EventArgs e);
        void DoValueSet(object sender, EventArgs e);
        
        
    }

    public interface IComboController : IDisposeContainer
    {
        int SelectedIndex { get; set; }
        bool FilterInative { get; set; }
        int Count();
        object GetSelected();
        object GetSelectedId();
        Task RefreshAsync();
    }
    public interface IComboController<TView, TKey> : IComboController
    {
        Task UseAsync(IPragmaComboBox combo, Expression<Func<TView, TKey>> key, Expression<Func<TView, object>> value);
        TKey GetSelectedKey();
        TView GetSelectedView();
        void SelectedChanceItem(TView o);
        Task<IEnumerable<TView>> GetForComboAsync();
    }
    public interface IComboController<TView> : IComboController<TView, int>
    {
    }
}
