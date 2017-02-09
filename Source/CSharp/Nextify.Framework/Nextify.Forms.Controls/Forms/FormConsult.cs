using Nextify.Abstraction;
using Nextify.Abstraction.Files;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Abstraction.IOC;
using Nextify.Core;
using Nextify.Core.Icons;
using Nextify.Excel;
using Nextify.Files;
using Nextify.IOC;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nextify.Forms.Controls.Forms
{
    public partial class FormConsult : FormBase
    {
        protected IGridController GridController;

        public bool HasEdit { get; set; } = true;
        public bool HasAdd { get; set; } = true;
        public bool HasDelete { get; set; } = false;
        public bool HasInative { get; set; } = true;
        private bool Loaded { get; set; } = false;
        protected bool Filter { get; set; }
        protected bool FilterInative { get; set; }
        protected IContainer _container { get; set; } = ContainerFactory.Instance;

        public bool ForceRefreshFromDatabase = true;

        private Type _FormEditType;

        public FormConsult(IGridController gridController)
        {
            InitializeComponent();

            if (DesignMode)
                return;

            
            GridController = gridController;
            

        }
        public FormConsult()
        {
            InitializeComponent();
        }
        public void Configure(IGridController gridController)
        {
            GridController = gridController;
            GridController.ForceRefreshFromDatabase = ForceRefreshFromDatabase;
            gridController.StartLoad += (s, e) => StartLoad(Messages.Loading);
            gridController.EndLoad += (s, e) => { StopLoad(); };

            AddContextMenus();
        }
        public void SetFormEdit<TForm>() where TForm : FormEdit
        {
            _FormEditType = typeof(TForm);
        }
        public FormEdit GetEditForm()
        {
            if (_FormEditType == null)
                throw new Exception("FormEdit type was not set");

            var form = _container.Resolve(_FormEditType) as FormEdit;

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
            if (EditForm.ID != null)
                await RefreshGrid(EditForm.ID);

        }

        public async virtual Task Inative()
        {
            var id = GridController.GetSelectedId();
            var item = GridController.GetSelected() as IInative;

            if (item == null)
                throw new Exception("The item dont implements IInative");

            if (id == null)
                return;

            var question = ShowMessageQuestion($"{ (!item.Inative ? Messages.WantToInative : Messages.WantToAtive) } (ID:{id.ToString()})", Messages.Attention);

            if (question)
            {
                var result = await GridController.TryInativate(id);

                ShowMessage(result);

                if (result.Success)
                    await RefreshGrid();
            }
        }

        public async Task RefreshGrid(object id = null)
        {

            Grid.Enabled = false;
            await GridController.RefreshAsync();
            if (id != null)
                GridController.SetSelectedPosition(id);
            Grid.Enabled = true;
        }

        public virtual async Task Delete()
        {
            var id = GridController.GetSelectedId();

            if (id == null)
                return;

            var question = ShowMessageQuestion($"{Messages.WantToDelete} (ID:{id.ToString()})", Messages.Attention);

            if (question)
            {
                var result = await GridController.TryDelete(id);

                ShowMessage(result);

                if (result.Success)
                    await RefreshGrid();
            }
        }

        private void AddContextMenus()
        {

            if ((HasEdit || HasAdd || HasDelete || HasInative) && GridController.HasMenus())
                GridController.AddMenuSeparator(0);

            if (HasDelete)
                GridController.InsertAsyncMenu(Messages.Delete, Delete, BaseIcons.trash, 0);

            if (HasInative)
                GridController.InsertAsyncMenu(e => ((IInative)e).Inative ? Messages.Ative : Messages.Inative, Inative, BaseIcons.edit_property, 0);

            if (HasAdd)
                GridController.InsertAsyncMenu(Messages.New, Add, BaseIcons.add_list, 0);

            if (HasEdit)
                GridController.InsertAsyncMenu(Messages.Edit, Edit, BaseIcons.edit, 0);
        }

        private void cmdFilter_Click(object sender, EventArgs e)
        {
            Filter = !Filter;
            cmdFilter.BackgroundImage = Filter ? BaseIcons.filled_filter : BaseIcons.empty_filter;
        }

        private async void cmtFilterInative_Click(object sender, System.EventArgs e)
        {
            FilterInative = !FilterInative;
            cmtFilterInative.BackgroundImage = FilterInative ? BaseIcons.glasses_invert : BaseIcons.glasses;

            GridController.FilterInative = FilterInative;
            var id = GridController.GetSelectedId();
            await GridController.RefreshAsync();
        }

        private async void FormConsult_LoadAsync(object sender, System.EventArgs e)
        {
            if (DesignMode)
                return;

            await RunWithLoadAsync(DoLoad, "Carregando...");
        }

        public async Task DoLoad()
        {
            if (Loaded)
                return;

            Loaded = true;
            cmdAdd.Visible = HasAdd;
            cmdDelete.Visible = HasDelete;
            cmdEditar.Visible = HasEdit;
            cmdInative.Visible = HasInative;

            if (GridController != null)
                Configure(GridController);

            await GridController.UseAsync(Grid);
            await FormLoadAsync();
        }

        private async void cmdRefresh_Click(object sender, System.EventArgs e)
        {
            await RefreshGrid();
        }

        //TODO: Mover para o controller
        /*private void Grid_CustomDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1 && e.RowIndex < Grid.GetRows().Count)
                GridController.RunFirstMenuItem();
        }*/

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            RegisterDispose(GridController);
            base.OnFormClosed(e);
        }

        private async void cmdExcel_Click(object sender, EventArgs e)
        {
            var excelTool = _container.Resolve<IExcelTool>();
            var dialog = _container.Resolve<IFileDialogTool>();

            var location = dialog.PutFile(FileExtensions.Excel);

            if (location == string.Empty)
                return;

            await RunActionWithLoadAsync(() => GridController.ExportToExcel(excelTool, location), Messages.Exporting);

        }

        private async void cmdEditar_Click(object sender, EventArgs e)
        {
            await Edit();
        }

        private async void cmdAdd_Click(object sender, EventArgs e)
        {
            await Add();
        }

        private async void cmdDelete_Click(object sender, EventArgs e)
        {
            await Delete();
        }

        private async void cmdInative_Click(object sender, EventArgs e)
        {
            await Inative();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            if (GridController.F4Mode)
            {
                this.DialogResult = DialogResult.None;
                Hide();

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }

        }

    }
}
