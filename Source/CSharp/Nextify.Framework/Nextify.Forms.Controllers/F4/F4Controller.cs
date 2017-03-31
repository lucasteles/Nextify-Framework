using Nextify.Business.Abstraction;
using Nextify.Core;
using Nextify.Extensions;
using Nextify.Forms.Controls;
using Nextify.Forms.Controls.Forms;
using Nextify.IOC;
using ModelViewBinder;
using System;
using System.Threading.Tasks;
using Nextify.Abstraction;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Abstraction.Business;
using Nextify.Abstraction.IOC;
using Nextify.Abstraction.Forms.Controls.Abstraction;
using ModelViewBinder.Forms;

namespace Nextify.Forms.Controllers
{
    public class F4Controller<TModel> : F4Controller<TModel, int> where TModel : class, IModelWithKey, new()
    {
        public F4Controller(IGridController grid, IBusiness<TModel> business) : base(grid, business)
        {

        }
    }

    public class F4Controller<TModel, TKey> : F4SimpleController<TModel> where TModel : class, IModelWithKey<TKey>, new()
    {
        protected IBusiness<TModel, TKey> Business;
        public bool ValidInative { get; set; } = true;

        public F4Controller(IGridController grid, IBusiness<TModel, TKey> business) : base(grid)
        {
            Business = business;
        }

        protected override bool BaseValidate()
        {
            var item = F4.ValueText;

            if (!(item is TKey))
                throw new Exception("The model of F4 dont match with the business Key type");

            var key = (TKey)item;

            if (key.Equals(default(TKey)) || key?.ToString() == string.Empty)
            {
                Model = null;
                F4.Value = null;
                Binder.SetSource(Model);
                Binder.FillTargets();
                return true;
            }
            Model = Business.GetForEdit(key);

            Binder.SetSource(Model);
            Binder.FillTargets();
            if (Model == null)
            {
                F4.ShowTootipMessage(Messages.InvalidKey, FailureSeverity.Warning);
                return false;
            }
            if (ValidInative)
            {
                if (Model is IInative)
                {
                    var inativeEntity = (IInative)Model;
                    if (inativeEntity.Inative)
                    {
                        F4.ShowTootipMessage(Messages.InativedItem, FailureSeverity.Warning);
                        return false;
                    }
                }
            }
            if (Validate())
            {
                F4.Value = Model;
                F4.DoChange();
                return true;
            }
            else
                return false;
        }
    }

    public class F4SimpleController<TModel> : IF4Controller<TModel>, IDisposable where TModel : class, new()
    {
        public TModel Model { get; set; }
        protected IGridController GridController;
        protected IContainer Container;
        protected IModelViewBinder<TModel> Binder;

        protected Type FormType { get; set; } = typeof(F4Form);
        protected NextifyF4TextBox F4;

        protected FormConsult Form;

        public F4SimpleController(IGridController grid)
        {
            GridController = grid;
            Container = IOC.ContainerFactory.Instance;
        }

        public void SetForm<TForm>() where TForm : FormConsult
        {
            FormType = typeof(TForm);
        }

        public virtual async Task<IModelViewBinder<TModel>> UseAsync(INextifyF4TextBox textbox)
        {
            F4 = (NextifyF4TextBox)textbox;
            F4.OnCallWindow += WindowOpen;
            F4.OnSetValue += OnSetValue;
            F4.Validating += (s, e) => OnValid();
            F4.OnValidate += (s, e) => OnValid();

            var defaultValue = new TModel().GetKeyAtributteValue();
            F4.ValueText = defaultValue;

            var form = Container.Resolve(FormType) as FormConsult;
            Form = form;
            if (form is F4Form)
                await (form as F4Form).SetController(GridController);
            else
                await form.DoLoad();

            Binder = new FormModelViewBinder<TModel>();

            return Binder;
        }

        protected async virtual void OnWindowOpenAsync()
        {
            await Task.FromResult(0);
        }

        protected virtual void WindowOpen(object sender, EventArgs args)
        {
            OnWindowOpenAsync();

            Form?.ShowDialog();

            var item = (TModel)GridController.Value;
            F4.Value = Model = item;
            if (item != null)
                F4.ValueText = (item.GetKeyAtributteValue());

            F4.Focus();
        }

        protected void OnSetValue(object sender, EventArgs args)
        {
            if (sender == null || sender.Equals(Model))
                return;

            if (!(sender is TModel))
                throw new Exception("The model seted dont match with the F4 Controller Model type");

            var model = (TModel)sender;

            F4.ValueText = model.GetKeyAtributteValue();
            Model = model;

            BaseValidate();
        }

        protected void OnValid()
        {
            F4.Valid = BaseValidate();
            F4.DoChange();
        }

        protected virtual bool BaseValidate()
        {
            Binder.SetSource(Model);
            Binder.FillTargets();
            return Validate();
        }
        protected virtual bool Validate()
        {
            return true;
        }

        public void Dispose()
        {
            Form?.Close();
        }
    }
}
