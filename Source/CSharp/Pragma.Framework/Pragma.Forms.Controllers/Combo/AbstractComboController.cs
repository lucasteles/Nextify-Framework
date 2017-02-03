using Pragma.Abstraction.Forms.Controls;
using Pragma.Extensions;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers.Abstraction
{
    public abstract class AbstractComboController<TView, TKey> : IComboController<TView, TKey>
    {
        #region Propriedades
        /// <summary>
        /// Objeto da combo relacionado
        /// </summary>
        protected PragmaComboBox PgmCombo { get; set; }
        /// <summary>
        /// Lista que está vinculada à Grid.
        /// </summary>
        public IList<TView> ComboList { get; set; }
        public bool FilterInative { get; set; }
        public int SelectedIndex { get; set; } = 0;
        public IList<IDisposable> Disposables { get; set; } = new List<IDisposable>();
        Func<TView, TKey> ExpKey { get; set; }
        Func<TView, object> ExpValue { get; set; }
        #endregion

        #region Metodos
        public abstract void SetPredicate(Expression<Func<TView, bool>> predicate);
        public abstract void SetOrder(Expression<Func<TView, object>> predicate);
        public abstract Task<IEnumerable<TView>> GetForComboAsync();
        public void SetSelectedId(TKey key)
        {
            if (typeof(TKey) == typeof(string))
            {
                var handler = ExpKey;
                if (handler != null)
                    SelectedIndex = ComboList.FindIndex(o => handler(o).ToString().Trim().Equals(key));
            }
            else
            {
                var handler = ExpKey;
                if (handler != null)
                    SelectedIndex = ComboList.FindIndex(o => handler(o).Equals(key));
            }

            if (SelectedIndex >= 0)
                PgmCombo.SelectedIndex = SelectedIndex;
        }
        public virtual TView GetSelectedView()
        {
            return ComboList[SelectedIndex];
        }
        public object GetSelected()
        {
            return GetSelectedView();
        }
        public TKey GetSelectedKey()
        {
            var item = ComboList[SelectedIndex];

            var keyValue = item.GetPropertyValue(PgmCombo.ValueMember);

            if (keyValue == null)
                throw new Exception("A view não tem uma key definida");

            return (TKey)keyValue;
        }

        public object GetSelectedId()
        {
            return GetSelectedKey();
        }
        public virtual async Task UseAsync(IPragmaComboBox combo, Expression<Func<TView, TKey>> key, Expression<Func<TView, object>> value)
        {
            PgmCombo =(PragmaComboBox)combo;

            ExpKey = key.Compile();
            ExpValue = value.Compile();

            PgmCombo.ValueMember = key.GetPropertyInfo().Name;
            PgmCombo.DisplayMember = value.GetPropertyInfo().Name;

            PgmCombo.SelectedIndexChanged += PgmComboBox_SelectedIndexChanged;
            PgmCombo.ValueSet += PgmComboBox_ValueSet;
            PgmCombo.ValueGet += PgmComboBox_ValueGet;

            await RefreshAsync();
        }
        private void PgmComboBox_ValueSet(object sender, EventArgs e)
        {
            SetSelectedId((TKey)sender);
        }
        private void PgmComboBox_ValueGet(object sender, EventArgs e)
        {
            PgmCombo.Value = GetSelectedId();
        }
        public int Count()
        {
            return ComboList.Count;
        }
        public virtual async Task RefreshAsync()
        {
            if (PgmCombo == null)
                return;

            var result = await GetForComboAsync();
            ComboList = result as IList<TView> ?? result.ToList();

            PgmCombo.BindList(ComboList);
        }
        public void RegisterDispose(IDisposable itemToDispose)
        {
            Disposables.Add(itemToDispose);
        }
        public virtual void Dispose()
        {
            foreach (var item in Disposables)
                item.Dispose();
        }
        #endregion

        #region Eventos
        private void PgmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = PgmCombo.SelectedIndex;
            SelectedChanceItem(GetSelectedView());
        }
        /// <summary>
        /// Executa ao selecionar um novo item
        /// </summary>
        /// <param name="o">Item selecionado na lista</param>
        public abstract void SelectedChanceItem(TView o);
        #endregion
    }
    public abstract class AbstractComboController<TView> : AbstractComboController<TView, int>
    {
    }
}
