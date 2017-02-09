using Nextify.Abstraction.Forms.Controller;
using Nextify.Abstraction.Forms.Controllers;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Abstraction.IOC;
using Nextify.Core;
using Nextify.Core.Icons;
using Nextify.Forms.Controllers.Abstraction;
using Nextify.Forms.Controls;
using Nextify.Forms.Controls.Forms;
using Nextify.IOC;
using System;
using System.Threading.Tasks;

namespace Nextify.Forms.Controllers.GridItems
{
    public abstract class AbstractItemsContainerController<TModel> : IItemsContainerController where TModel : class, new()
    {
        readonly IContainer _container = ContainerFactory.Instance;

        protected NextifyItemsContainer _gridItems;

        protected Type FormEditType;

        public Func<IFormEdit> GetEditFormAction { get; set; }  

        public bool HasAdd { get; set; } = true;

        public bool HasEdit { get; set; } = true;
        public bool HasRemove { get; set; } = true;

        readonly protected IGridController GridController;

        protected AbstractItemsContainerController(IGridController gridForItemsController)
        {
            GridController = gridForItemsController;
            GetEditFormAction = GetEditForm;
        }

        public void SetFormEdit<TForm>() where TForm : IFormEdit
        {
            FormEditType = typeof(TForm);
        }

        public async Task UseAsync(INextifyItemsContainer items)
        {

            _gridItems = (NextifyItemsContainer)items;

            _gridItems.OnGetValue += OnGet;
            _gridItems.OnSetValue += OnSet;

            ConfigureMenus();
            if (GridController is AbstractGridSimpleBusinessController<TModel, TModel>)
            {
                ((AbstractGridSimpleBusinessController<TModel, TModel>)GridController).UseDatabaseDynamicSearch = false;
            }

            await Task.FromResult(0);
        }

        protected abstract void OnGet(object sender, EventArgs e);
        protected abstract void OnSet(object sender, EventArgs e);

        protected void ConfigureMenus()
        {
            if ((HasEdit || HasAdd || HasRemove) && GridController.HasMenus())
                GridController.AddMenuSeparator(0);

            if (HasRemove)
                GridController.InsertAsyncMenu(Messages.Remove, RemoveAsync, BaseIcons.trash, 0);

            if (HasAdd)
                GridController.InsertAsyncMenu(Messages.New, AddAsync, BaseIcons.add_list, 0);

            if (HasEdit)
                GridController.InsertAsyncMenu(Messages.Edit, EditAsync, BaseIcons.edit, 0);
        }
       protected  FormEdit GetEditForm()
        {
            if (FormEditType == null)
                throw new Exception("FormEdit type was not set");

            var form = _container.Resolve(FormEditType) as FormEdit;
            form.PersistData = false;

            if (_gridItems.ParentForm is FormBase)
                form.SetParentForm((FormBase)_gridItems.ParentForm);

            return form;

        }
        public abstract Task AddAsync();

        public abstract Task EditAsync();

        public abstract Task RemoveAsync();

    }
}
