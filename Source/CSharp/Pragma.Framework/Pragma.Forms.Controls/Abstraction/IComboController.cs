using Pragma.Core;
using Pragma.Forms.Controls;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls
{
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
        Task UseAsync(PragmaComboBox combo, Expression<Func<TView, TKey>> key, Expression<Func<TView, object>> value);
        TKey GetSelectedKey();
        TView GetSelectedView();
        void SelectedChanceItem(TView o);
    }
    public interface IComboController<TView> : IComboController<TView, int>
    {
    }
}
