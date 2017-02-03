using Pragma.Abstraction.Forms.Controllers.GridItems;
using Pragma.Abstraction.Forms.Controls;
using Pragma.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers.GridItems
{
    public class PragmaItemsContainerController<TModel, TView> : AbstractPragmaItemsContainerController<TModel>, IPragmaItemsContainerController where TModel : class, new()
    {
        protected IMapper Mapper;

        public IList<TModel> Items { get; set; }
        IDictionary<TView, TModel> ModelMap { get; set; }

        protected readonly new IGridListController<TView> GridController;

        public PragmaItemsContainerController(IGridListController<TView> gridController) : base(gridController)
        {
            GridController = gridController;
            Mapper = IOC.ContainerFactory.Instance.Resolve<IMapper>();
        }

        private async Task ConfigureMappingAsync()
        {
            ModelMap = new Dictionary<TView, TModel>();
            foreach (var item in Items)
                ModelMap.Add(Mapper.Map<TView>(item), item);
            GridController.Items = ModelMap.Keys.ToList();
            await GridController.UseAsync(_gridItems);
        }
        protected override void OnGet(object sender, EventArgs e)
        {
            _gridItems._value = Items;

        }

        protected override async void OnSet(object sender, EventArgs e)
        {
            Items = (sender as IEnumerable<TModel>).ToList();
            await ConfigureMappingAsync();
        }

        public override async Task AddAsync()
        {
            var EditForm = GetEditForm();
            EditForm.ShowDialog();
            if (EditForm.ItemsModel != null)
            {
                Items.Add(EditForm.ItemsModel as TModel);
                await ConfigureMappingAsync();
                GridController.SetSelectedPosition(Items.Count() - 1);

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
                var selectedView = GridController.GetSelected();
                var item = ModelMap[selectedView];
                EditForm.ShowDialog(item);
                await ConfigureMappingAsync();

            }
            await Task.FromResult(0);
        }

        public override async Task RemoveAsync()
        {
            var selectedView = GridController.GetSelected();
            var item = ModelMap[selectedView];
            Items.Remove(item);
            await ConfigureMappingAsync();
            await Task.FromResult(0);
        }
    }
}
