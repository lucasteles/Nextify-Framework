using Pragma.Forms.Controls.Abstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers.GridItems
{
    public class PragmaItemsContainerController<TModel> : AbstractPragmaItemsContainerController<TModel>, IPragmaItemsContainerController where TModel : class, new()
    {
        public IList<TModel> Items { get; set; }

        protected readonly new IGridListController<TModel> GridController;

        public PragmaItemsContainerController(IGridListController<TModel> gridForItemsController) : base(gridForItemsController)
        {
            GridController = gridForItemsController;

        }
        public override async Task AddAsync()
        {
            var EditForm = GetEditForm();
            EditForm.ShowDialog();
            if (EditForm.ItemsModel != null)
            {
                Items.Add(EditForm.ItemsModel as TModel);
            }

            await Task.FromResult(0);

        }

        public async override Task EditAsync()
        {
            var EditForm = GetEditForm();

            if (GridController.Count() == 0)
                await AddAsync();

            else
            {
                var item = GridController.GetSelected();
                EditForm.ShowDialog(item);

            }
            await Task.FromResult(0);
        }

        public override async Task RemoveAsync()
        {
            Items.Remove(GridController.GetSelected());
            await Task.FromResult(0);
        }
        protected override void OnGet(object sender, EventArgs e)
        {
            _gridItems._value = Items;

        }

        protected override async void OnSet(object sender, EventArgs e)
        {
            GridController.Items = Items = sender as IList<TModel>;
            await GridController.UseAsync(_gridItems);
        }
    }
}
