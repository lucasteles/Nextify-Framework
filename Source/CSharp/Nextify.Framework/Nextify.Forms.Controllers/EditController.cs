using Nextify.Business.Abstraction;
using Nextify.Core;
using Nextify.Forms.Controls;
using Nextify.Forms.Controls.Forms;
using ModelViewBinder;
using System.Threading.Tasks;
using Nextify.Abstraction.Forms.Controllers;
using Nextify.Abstraction;
using Nextify.Abstraction.Business;

namespace Nextify.Forms.Controllers
{
    public class EditController<TEntity, TKey> : IEditController<TEntity, TKey> where TEntity : class, IModelWithKey<TKey>, new()
    {

        private FormEdit _form;

        public IModelViewBinder<TEntity> Binder { get; set; }

        public TEntity Model { get; set; }

        protected IBusiness<TEntity, TKey> Business { get; set; }

        public bool PersistData { get; set; } = true;

        public EditController(IModelViewBinder<TEntity> binder)
        {
            Binder = binder;
        }
        public async Task<IModelViewBinder<TEntity>> UseAsync(IFormEdit form, IBusiness<TEntity, TKey> business)
        {
            PersistData = form.PersistData;
            _form = (FormEdit)form;
            var Id = (TKey)(form.ID ?? default(TKey));
            Business = business;

            _form.StartLoad(Messages.Loading);
            Binder.DisableAll();

            _form._binder = Binder;

            _form.cmdOk.Click += cmdOk_ClickAsync;
            _form.FormClosed += (s, e) => Dispose();

            if (PersistData)
                _form.RegisterDispose(Business);

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
                _form.lblId.Text = $"ID: {Model.Id.ToString()}";
            }

            Binder.SetSource(Model);
            //Binder.EnableAll();
            //form.StopLoad();

            return Binder;
        }

        protected async virtual Task<bool> AddEntityAsync()
        {
            var result = !PersistData ? await Business.ValidAsync(Model) : await Business.AddAsync(Model);

            _form.ShowMessage(result);
            _form.ID = Model.Id;

            if (!PersistData)
                if (result.Success)
                    _form.ItemsModel = Model;
                else
                    _form.ItemsModel = null;

            return result.Success;
        }

        protected async virtual Task<bool> UpdateAsync()
        {
            var result = !PersistData ? await Business.ValidAsync(Model) : await Business.UpdateAsync(Model);
            _form.ShowMessage(result);
            return result.Success;
        }

        private async void cmdOk_ClickAsync(object sender, System.EventArgs e)
        {
            var button = sender as NextifyButton;
            var result = true;

            _form.StartLoad(Messages.Saving);
            Binder.DisableAll();
            button.Enabled = false;

            if (!PersistData)
                Binder.FillSource();

            if (await _form.ValidateAsync())
            {
                
                   
                if (Model.Id.Equals(default(TKey)))
                    result = await AddEntityAsync();
                else
                    result = await UpdateAsync();
            }
            else
            {
                result = false;
            }
            button.Enabled = true;
            Binder.EnableAll();
            _form.StopLoad();

            if (result)
                _form.Close();
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