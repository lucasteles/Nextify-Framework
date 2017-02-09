using Nextify.Abstraction.Forms.Controller;
using Nextify.Abstraction.Forms.Controllers.GridItems;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Forms.Controllers.GridItems;
using Nextify.Forms.Controls.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nextify.Forms.Controllers.GridItems
{
    public class ItemsContainerController<TModel> : AbstractItemsContainerController<TModel>, IItemsContainerController where TModel : class, new()
    {
        public IList<TModel> Items { get; set; }

        protected readonly new IGridListController<TModel> GridController;

        public ItemsContainerController(IGridListController<TModel> gridForItemsController) : base(gridForItemsController)
        {
            GridController = gridForItemsController;

        }
        public override async Task AddAsync()
        {
            var EditForm = GetEditFormAction();
            (EditForm as FormEdit).ShowDialog();
            if (EditForm.ItemsModel != null)
            {
                Items.Add(EditForm.ItemsModel as TModel);
                await _gridItems.ValidateAsync();
            }

            await GridController.RefreshAsync();
            

        }

        public async override Task EditAsync()
        {
            var EditForm = GetEditFormAction();

            if (GridController.Count() == 0)
                await AddAsync();

            else
            {
                var item = GridController.GetSelected();
                EditForm.ShowDialog(item);

            }
            await _gridItems.ValidateAsync();
            await GridController.RefreshAsync();
        }

        public override async Task RemoveAsync()
        {
            Items.Remove(GridController.GetSelected());
            _gridItems._value = Items;
            await _gridItems.ValidateAsync();
            await GridController.RefreshAsync();
        }
        protected override void OnGet(object sender, EventArgs e)
        {
            _gridItems._value = Items;

        }

        protected override async void OnSet(object sender, EventArgs e)
        {
            if (sender!=null)
            GridController.Items = Items = ((IEnumerable<TModel>)sender).ToList();

            await GridController.UseAsync(_gridItems);
        }
    }
}
