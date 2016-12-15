using Pragma.IOC;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls.Forms
{
    public partial class FormConsult : FormBase
    {

        IGridController GridController;

        public bool HasEdit { get; set; } = true;
        public bool HasAdd { get; set; } = true;
        public bool HasDelete { get; set; } = true;

        private bool Filter { get; set; }
        private bool FilterInative { get; set; }
        protected IContainer _container { get; set; }

        private Type FormEditType = null;

        public FormConsult(IGridController gridController, IContainer container)
        {
            GridController = gridController;
            _container = container;

            InitializeComponent();
            AddContextMenus();
        }

        public void SetFormEdit<TForm>() where TForm : FormEdit
        {
            FormEditType = typeof(TForm);
        }

        public FormEdit GetEditForm()
        {
            if (FormEditType == null)
                throw new Exception("FormEdit type was not set");

            var form = _container.Resolve(FormEditType) as FormEdit;

            form.SetParentForm(this);

            return form;

        }

        public async virtual Task Edit()
        {
            var EditForm = GetEditForm();

            if (GridController.Count() == 0)
                await Add();

            else
            {
                var id = GridController.GetSelectedId();
                EditForm.ShowDialog(id);

            }

            await RefreshGrid(EditForm.ID);

        }


        public async virtual Task Add()
        {
            var EditForm = GetEditForm();
            EditForm.ShowDialog();

            await RefreshGrid(EditForm.ID);

        }

        public async Task RefreshGrid(object id = null)
        {
            StartLoad(Messages.Loading);
            Grid.Enabled = false;
            await GridController.Refresh();
            if (id != null)
                GridController.SetSelectedPosition(id);
            Grid.Enabled = true;
            StopLoad();
        }

        public virtual async Task Delete()
        {
            var id = GridController.GetSelectedId();

            if (id == null)
                return;

            var question = ShowMessageQuestion($"{Messages.WantToDelete} (ID:{id.ToString()})", Messages.Attention);

            if (question)
            {
                var result = GridController.TryDelete(id);

                ShowMessage(result);

                if (result.Success)
                    await RefreshGrid();

            }

        }


        private void AddContextMenus()
        {

            if ((HasEdit || HasAdd || HasDelete) && GridController.HasMenus())
                GridController.AddMenuSeparator(0);


            if (HasDelete)
                GridController.InsertAsyncMenu(Messages.Delete, Delete, BaseIcons.trash, 0);

            if (HasAdd)
                GridController.InsertAsyncMenu(Messages.New, Add, BaseIcons.add_list, 0);


            if (HasEdit)
                GridController.InsertAsyncMenu(Messages.Edit, Edit, BaseIcons.edit, 0);


        }




        private void cmdFilter_Click(object sender, System.EventArgs e)
        {
            Filter = !Filter;
            if (Filter)
                cmdFilter.BackgroundImage = BaseIcons.filled_filter;
            else
                cmdFilter.BackgroundImage = BaseIcons.empty_filter;
        }

        private void cmtFilterInative_Click(object sender, System.EventArgs e)
        {
            FilterInative = !FilterInative;
            if (FilterInative)
                cmtFilterInative.BackgroundImage = BaseIcons.glasses_invert;
            else
                cmtFilterInative.BackgroundImage = BaseIcons.glasses;
        }

        private async void FormConsult_Load(object sender, System.EventArgs e)
        {

            await GridController.Use(Grid);

            await FormLoad();
        }

        private async void cmdRefresh_Click(object sender, System.EventArgs e)
        {
            await RefreshGrid();
        }


        private void Grid_CustomDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            GridController.RunFirstMenuItem();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            RegisterDispose(GridController);
            base.OnFormClosed(e);
        }
    }
}
