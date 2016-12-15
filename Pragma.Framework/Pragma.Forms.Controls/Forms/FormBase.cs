using MetroFramework;
using MetroFramework.Forms;
using Pragma.Core;

using Pragma.Forms.Controls.Abstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls.Forms
{
    public partial class FormBase : MetroForm, IDisposeContainer
    {
        private bool _loading = false;

        public bool Loading { get { return _loading; } }

        private FormBase _parent = null;

        public IList<IDisposable> Disposables = new List<IDisposable>();
        public FormBase()
        {
            InitializeComponent();
            StyleManager = MetroStyleManager;


            StopLoad();


        }

        public void SetParentForm(FormBase form)
        {
            _parent = form;

            if (_parent.StyleManager != null)
                this.StyleManager = _parent.StyleManager;

        }

        public async virtual Task FormLoad()
        {
            await Task.FromResult(0);
        }


        public void StartLoad(string text)
        {
            SpinnerLoad.Value = 0;
            SpinnerLoad.Spinning = true;
            SpinnerLoad.Visible = true;
            lblLoading.Text = "  " + text;
            TopPanel.Visible = true;

            _loading = true;
            var switches = new BehaviorSubject<bool>(true);
            var load = Observable.Interval(TimeSpan.FromSeconds(.05)).TakeUntil(switches.Where(on => !on));
            bool stop = false;
            var loadSub = load.ObserveOn(this).Subscribe(t =>
                     {
                         var newValue = SpinnerLoad.Value;

                         if (!stop)
                             newValue = (newValue + 1);
                         else
                             newValue = (newValue - 1);

                         if (newValue == 100 || newValue == 0)
                             stop = !stop;
                         else
                             SpinnerLoad.Value = newValue;

                         switches.OnNext(_loading);



                     });

            RegisterDispose(loadSub);

        }

        public void StopLoad()
        {
            lblLoading.Text = string.Empty;
            SpinnerLoad.Spinning = false;
            SpinnerLoad.Visible = false;
            _loading = false;
        }

        public void SetLoading(int value, string message = "")
        {
            if (message != string.Empty)
                lblLoading.Text = message;

            TopProgressbar.Value = value > 100 ? 0 : value;
            TopProgressbar.Visible = !(value == 0);

            if (TopProgressbar.Visible)
                TopProgressbar.Height = 5;
            else
                TopProgressbar.Height = 0;
        }


        public async Task RunWithLoad(Func<Task> resultBody, string message)
        {
            StartLoad(message);

            await resultBody();

            StopLoad();
        }


        public async Task<T> RunWithLoad<T>(Func<Task<T>> resultBody, string message)
        {
            StartLoad(message);
            var result = await resultBody();
            StopLoad();
            return result;
        }


        public async Task RunWithLoad(Func<Task> resultBody, string message, Control control)
        {
            control.Enabled = false;
            await RunWithLoad(resultBody, message);
            control.Enabled = true;

        }

        public async Task<T> RunWithLoad<T>(Func<Task<T>> resultBody, string message, Control control)
        {
            control.Enabled = false;
            var result = await RunWithLoad(resultBody, message);
            control.Enabled = true;
            return result;
        }


        public async Task RunActionWithLoad(Action resultBody, string message)
        {
            StartLoad(message);

            await Task.Run(() => resultBody());

            StopLoad();
        }


        public async Task RunActionWithLoad(Action resultBody, string message, Control control)
        {

            StartLoad(message);
            control.Enabled = false;
            await new Task(resultBody);
            control.Enabled = true;
            StopLoad();
        }




        public void ShowMessage(string message, string title = "Aviso", FailureSeverity type = FailureSeverity.Warning)
        {
            var @switch = new Dictionary<FailureSeverity, MessageBoxIcon>()
            {
                [FailureSeverity.Error] = MessageBoxIcon.Error,
                [FailureSeverity.Info] = MessageBoxIcon.Information,
                [FailureSeverity.Warning] = MessageBoxIcon.None
            };

            MetroMessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        public bool ShowMessageQuestion(string message, string title = "Como prosseguir?")
        {
            var dr = MetroMessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            return dr == DialogResult.Yes;
        }


        public virtual void ShowMessage(IOperationResult operation, string title = null)
        {
            if (operation == null)
                return;

            var warnings = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Warning).Select(e => e.Message);
            var errors = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Error).Select(e => e.Message);
            var info = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Info).Select(e => e.Message);

            if (info.Count() > 0)
                ShowMessage(string.Join("\n", info), title ?? "Info");

            if (warnings.Count() > 0)
                ShowMessage(string.Join("\n", warnings), title ?? "Aviso");

            if (errors.Count() > 0)
                ShowMessage(string.Join("\n", errors), title ?? "Erro");
        }


        public virtual void ShowControlTooltip(Control control, FailureSeverity severity, string message, string title = "")
        {
            if (!(control is IControl))
                throw new Exception("The control is not a IControl");

            ((IControl)control).ShowTootipMessage(message, severity, title);
        }



        protected virtual void FormBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var item in Disposables)
                item.Dispose();
        }

        public void RegisterDispose(IDisposable itemToDispose)
        {
            Disposables.Add(itemToDispose);
        }
    }
}
