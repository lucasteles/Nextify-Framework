using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.Controls;
using Pragma.Forms.Controls.Forms;
using ModelViewBinder;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public class EditController<TEntity, TKey> : IEditController<TEntity, TKey> where TEntity : class, IModelWithKey<TKey>, new()
    {

        private FormEdit form;

        public IModelViewBinder<TEntity> Binder { get; set; }

        public TEntity Model { get; set; }

        protected IBusiness<TEntity, TKey> Business { get; set; }

        public bool PersistData { get; set; } = true;

        public EditController(IModelViewBinder<TEntity> binder)
        {
            Binder = binder;
        }
        public async Task<IModelViewBinder<TEntity>> UseAsync(FormEdit form, IBusiness<TEntity, TKey> business)
        {
            PersistData = form.PersistData;
            this.form = form;
            var Id = (TKey)(form.ID ?? default(TKey));
            Business = business;

            form.StartLoad(Messages.Loading);
            Binder.DisableAll();

            form._binder = Binder;

            form.cmdOk.Click += cmdOk_ClickAsync;
            form.FormClosed += (s, e) => Dispose();
            form.RegisterDispose(Business);

            if (Id.Equals(default(TKey)) && form.ItemsModel == null)
                Model = new TEntity();
            else
            {
                if (PersistData)
                    Model = await business.GetForEditAsync(Id);
                //Model = business.GetForEdit(Id);
                else
                {
                    if (!(form.ItemsModel is TEntity))
                        throw new System.Exception("Item model dont match with edit form model");

                    Model = (TEntity)form.ItemsModel;
                }
                form.lblId.Text = $"ID: {Model.Id.ToString()}";
            }

            Binder.SetSource(Model);
            //Binder.EnableAll();
            //form.StopLoad();

            return Binder;
        }

        protected async virtual Task<bool> AddEntityAsync()
        {
            var result = !PersistData ? await Business.ValidAsync(Model) : await Business.AddAsync(Model);

            form.ShowMessage(result);
            form.ID = Model.Id;

            if (!PersistData)
                if (result.Success)
                    form.ItemsModel = Model;
                else
                    form.ItemsModel = null;

            return result.Success;
        }

        protected async virtual Task<bool> UpdateAsync()
        {
            var result = !PersistData ? await Business.ValidAsync(Model) : await Business.UpdateAsync(Model);
            form.ShowMessage(result);
            return result.Success;
        }

        private async void cmdOk_ClickAsync(object sender, System.EventArgs e)
        {
            var button = sender as PragmaButton;
            var result = true;

            form.StartLoad(Messages.Saving);
            Binder.DisableAll();
            button.Enabled = false;

            if (!PersistData)
                Binder.FillSource();

            if (await form.ValidateAsync())
            {
                if (Business.IsModified(Model))
                    result = await UpdateAsync();
                else if (Model.Id.Equals(default(TKey)))
                    result = await AddEntityAsync();
            }
            else
            {
                result = false;
            }
            button.Enabled = true;
            Binder.EnableAll();
            form.StopLoad();

            if (result)
                form.Close();
        }

        public void Dispose()
        {
            Binder.Dispose();
        }
    }

    public class EditController<TEntity> : EditController<TEntity, int>, IEditController<TEntity> where TEntity : class, IModelWithKey, new()
    {
        public EditController(IModelViewBinder<TEntity> binder) : base(binder)
        {
        }
    }
}