using Pragma.Forms.Controllers.Abstraction;
using Pragma.Forms.Controls;
using Pragma.Forms.Controls.Abstraction;
using Pragma.Forms.Controls.Forms;
using Pragma.IOC;
using System;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers.GridItems
{
    public abstract class AbstractPragmaItemsContainerController<TModel> : IPragmaItemsContainerController where TModel : class, new()
    {
        readonly IContainer _container = ContainerFactory.Container;

        protected PragmaItemsContainer _gridItems;

        protected Type FormEditType;

        public bool HasAdd { get; set; } = true;

        public bool HasEdit { get; set; } = true;
        public bool HasRemove { get; set; } = true;

        readonly protected IGridController GridController;

        protected AbstractPragmaItemsContainerController(IGridController gridForItemsController)
        {
            GridController = gridForItemsController;
        }

        public void SetFormEdit<TForm>() where TForm : FormEdit
        {
            FormEditType = typeof(TForm);
        }

        public async Task UseAsync(PragmaItemsContainer items)
        {

            _gridItems = items;

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
        protected FormEdit GetEditForm()
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
