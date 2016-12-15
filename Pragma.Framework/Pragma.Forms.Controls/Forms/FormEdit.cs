using Pragma.Core;
using Pragma.Forms.ControlBinding;
using System.Linq;
using System.Windows.Forms;

namespace Pragma.Forms.Controls.Forms
{

    public partial class FormEdit : FormBase
    {
        public IControlBinder _binder;

        public object ID { get; set; }


        public FormEdit()
        {
            InitializeComponent();
        }



        public virtual void RefreshControls()
        {
            _binder.FillControls();
        }

        public virtual void RefreshModel()
        {
            _binder.FillModel();
        }

        public override void ShowMessage(IOperationResult operation, string title = null)
        {
            if (operation == null)
                return;

            var warnings = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Warning);
            var errors = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Error).Select(e => e.Message);
            var info = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Info);

            if (info.Count() > 0)
            {
                foreach (var item in info)
                {
                    var control = _binder.GetControlFromProperty<Control>(item.Property);
                    ShowControlTooltip(control, item.Severity, item.Message);
                }
            }

            if (warnings.Count() > 0)
            {
                foreach (var item in warnings)
                {
                    var control = _binder.GetControlFromProperty<Control>(item.Property);
                    ShowControlTooltip(control, item.Severity, item.Message);
                }
            }

            if (errors.Count() > 0)
                ShowMessage(string.Join("\n", errors), title ?? "Erro");
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

        private async void FormEdit_Load(object sender, System.EventArgs e)
        {
            if (!DesignMode)
            {
                await FormLoad();
                _binder.SetForm(this);

                cmdOk.Click += cmdCancelar_Click;
            }
        }

        private void cmdCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }



    }



}
