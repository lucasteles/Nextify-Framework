using Pragma.Core;
using ModelViewBinder;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls.Forms
{
    public partial class FormEdit : FormBase
    {
        public IModelViewBinder _binder;
        public object ID { get; set; }
        public bool PersistData { get; set; } = true;

        public object ItemsModel { get; set; }

        public FormEdit()
        {
            InitializeComponent();
        }

        public virtual void RefreshControls()
        {
            _binder.FillTargets();
        }

        public virtual void RefreshModel()
        {
            _binder.FillSource();
        }

        public override bool ShowMessage(IOperationResult operation, string title = null)
        {
            if (operation == null)
                return true;

            var warnings = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Warning);
            var errors = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Error).Select(e => e.Message);
            var info = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Info);

            if (info.Count() > 0)
            {
                foreach (var item in info)
                {
                    var control = _binder.GetTargetFromProperty<Control>(item.Property);
                    ShowControlTooltip(control, item.Severity, item.Message);
                }
            }

            if (warnings.Count() > 0)
            {
                foreach (var item in warnings)
                {
                    var control = _binder.GetTargetFromProperty<Control>(item.Property);
                    ShowControlTooltip(control, item.Severity, item.Message);
                }
            }

            if (errors.Count() > 0)
                ShowMessage(string.Join("\n", errors), title ?? "Erro");

            return operation.Success;
        }

        public void Show(object id)
        {
            ID = id;
            Show();
        }

        public void ShowDialog(object id)
        {
            ID = id;
            ShowDialog();
        }

        public void ShowDialog<TModel>(TModel model) where TModel : class, new()
        {
            ItemsModel = model;
            ShowDialog();
        }
        public void Show<TModel>(TModel model) where TModel : class, new()
        {
            ItemsModel = model;
            Show();
        }
        private void FormEdit_Load(object sender, System.EventArgs e)
        {
            if (DesignMode)
                return;

            Enabled = false;
        }

        public override Task FormAfterLoadAsync()
        {
            if (PersistData)
                _binder.SetForm(this);
            else
                _binder.FillTargets();

            Enabled = true;
            StopLoad();

            return Task.FromResult(0);
        }
        private void cmdCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
