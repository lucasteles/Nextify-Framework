using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.ControlBinding;
using Pragma.Forms.Controls;
using Pragma.Forms.Controls.Controls;
using Pragma.Forms.Controls.Forms;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public class EditController<TEntity, TKey> : IEditController<TEntity, TKey> where TEntity : class, IModelWithId<TKey>, new() where TKey : struct
    {

        private FormEdit form;

        public IControlBinder<TEntity> Binder { get; set; }

        public TEntity Model { get; set; }

        protected IBusiness<TEntity, TKey> Business { get; set; }

        public EditController(IControlBinder<TEntity> binder)
        {
            Binder = binder;

        }

        public async Task<IControlBinder<TEntity>> Use(FormEdit form, IBusiness<TEntity, TKey> business)
        {
            this.form = form;
            var Id = (TKey)(form.ID ?? default(TKey));

            Business = business;

            form.StartLoad(Messages.Loading);
            Binder.DisableAll();

            form._binder = Binder;
            form.cmdOk.Click += cmdOk_Click;
            form.FormClosed += (s, e) => Dispose();


            if (Id.Equals(default(TKey)))
                Model = new TEntity();
            else
            {
                Model = await business.GetForEditAsync(Id);
                form.lblId.Text = $"ID: {Model.Id.ToString()}";
            }


            Binder.SetModel(Model);
            Binder.EnableAll();
            form.StopLoad();

            return Binder;

        }


        protected async virtual Task<bool> AddEntity()
        {

            var result = await Business.AddAsync(Model);
            form.ShowMessage(result);
            form.ID = Model.Id;
            return result.Success;

        }


        protected async virtual Task<bool> Update()
        {

            var result = await Business.UpdateAsync(Model);
            form.ShowMessage(result);
            return result.Success;

        }


        private async void cmdOk_Click(object sender, System.EventArgs e)
        {
            var button = sender as PragmaButton;
            bool result = true;

            form.StartLoad(Messages.Saving);
            Binder.DisableAll();
            button.Enabled = false;
            if (Business.IsModified(Model))
                result = await Update();
            else if (Model.Id.Equals(default(TKey)))
                result = await AddEntity();
            button.Enabled = true;
            Binder.EnableAll();
            form.StopLoad();



        }

        public void Dispose()
        {
            Business.Dispose();
            Binder.Dispose();
        }
    }

    public class EditController<TEntity> : EditController<TEntity, int>, IEditController<TEntity> where TEntity : class, IModelWithId, new()
    {
        public EditController(IControlBinder<TEntity> binder) : base(binder)
        {
        }
    }
}