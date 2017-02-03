using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
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
    public partial class FormBase : MetroForm, IDisposeContainer, IValidatable
    {
        private bool _loading;

        public bool Loading { get { return _loading; } }

        private FormBase _parent;

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

        public async virtual Task FormLoadAsync()
        {
            await Task.FromResult(0);
        }

        public async virtual Task FormAfterLoadAsync()
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
            var stop = false;
            var loadSub = load.ObserveOn(this).Subscribe(t =>
                     {
                         var newValue = SpinnerLoad.Value;

                         newValue = !stop ? (newValue + 1) : (newValue - 1);

                         if (newValue == 100 || newValue == 0)
                             stop = !stop;
                         else
                             SpinnerLoad.Value = newValue;

                         switches.OnNext(_loading);

                     });

            RegisterDispose(loadSub);
            RegisterDispose(switches);
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

        public async Task RunWithLoadAsync(Func<Task> resultBody, string message)
        {
            StartLoad(message);

            await resultBody?.Invoke();

            StopLoad();
        }

        public async Task<T> RunWithLoadAsync<T>(Func<Task<T>> resultBody, string message)
        {
            StartLoad(message);
            var result = await resultBody?.Invoke();
            StopLoad();
            return result;
        }

        public async Task<T> RunWithLoadAsync<T>(Task<T> task, string message, params Control[] control)
        {
            SetControlsEnabled(false, control);
            StartLoad(message);
            var result = await task;
            StopLoad();
            SetControlsEnabled(true, control);
            return result;
        }

        public async Task RunWithLoadAsync(Task task, string message, params Control[] control)
        {
            SetControlsEnabled(false, control);
            StartLoad(message);
            await task;
            StopLoad();
            SetControlsEnabled(true, control);

        }

        public async Task RunWithLoadAsync(Func<Task> resultBody, string message, params Control[] control)
        {
            SetControlsEnabled(false, control);
            await RunWithLoadAsync(resultBody, message);
            SetControlsEnabled(true, control);

        }

        public async Task<T> RunWithLoadAsync<T>(Func<Task<T>> resultBody, string message, params Control[] control)
        {
            SetControlsEnabled(false, control);
            var result = await RunWithLoadAsync(resultBody, message);
            SetControlsEnabled(true, control);
            return result;
        }

        public async Task RunActionWithLoadAsync(Action resultBody, string message)
        {
            StartLoad(message);

            await Task.Run(() => resultBody?.Invoke());

            StopLoad();
        }

        public async Task RunActionWithLoadAsync(Action resultBody, string message, params Control[] control)
        {
            StartLoad(message);
            SetControlsEnabled(false, control);

            await Task.Run(resultBody);

            SetControlsEnabled(true, control);
            StopLoad();
        }

        protected static void SetControlsEnabled(bool enabled, params Control[] controls)
        {
            foreach (var item in controls)
            {
                item.Enabled = enabled;
            }
        }

        public void ShowMessage(string message, string title = "Aviso", FailureSeverity type = FailureSeverity.Warning)
        {
            var @switch = new Dictionary<FailureSeverity, MessageBoxIcon>
            {
                [FailureSeverity.Error] = MessageBoxIcon.Error,
                [FailureSeverity.Info] = MessageBoxIcon.Information,
                [FailureSeverity.Warning] = MessageBoxIcon.None
            };

            MetroMessageBox.Show(this, message, title, MessageBoxButtons.OK, @switch[type]);
        }

        public bool ShowMessageQuestion(string message, string title = "Como prosseguir?")
        {
            var dr = MetroMessageBox.Show(this, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
            return dr == DialogResult.Yes;
        }

        public virtual bool ShowMessage(IOperationResult operation, string title = null)
        {
            if (operation == null)
                return true;

            var warnings = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Warning).Select(e => e.Message);
            var errors = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Error).Select(e => e.Message);
            var info = operation.ErrorList.Where(e => e.Severity == FailureSeverity.Info).Select(e => e.Message);

            if (info.Count() > 0)
                ShowMessage(string.Join("\n", info), title ?? "Info");

            if (warnings.Count() > 0)
                ShowMessage(string.Join("\n", warnings), title ?? "Aviso");

            if (errors.Count() > 0)
                ShowMessage(string.Join("\n", errors), title ?? "Erro");

            return operation.Success;
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

        public bool IsValid()
        {
            var result = true;
            foreach (var control in Controls)
            {
                if (control is IValidatable)
                {
                    var vcontrol = control as IValidatable;
                    result &= vcontrol.IsValid();
                }
            }

            return result;
        }

        protected IEnumerable<Control> GetAllControls(Control parent = null)
        {
            var typelist = new Type[] { typeof(Form), typeof(Panel), typeof(TabControl), typeof(TabPage) };

            return GetAllControls(parent, typelist);
        }

        protected IEnumerable<Control> GetAllControls(Control parent = null, params Type[] parentTypes)
        {
            var controls = new List<Control>();

            if (parent == null)
                parent = this;
            else
                controls.Add(parent);
            if (parent.HasChildren && parent.Controls.Count > 0 && (parentTypes == null || parentTypes.Any(o => o.IsAssignableFrom(parent.GetType()))))
            {
                foreach (Control item in parent.Controls)
                {
                    var children = GetAllControls(item, parentTypes);
                    controls.AddRange(children);
                }
            }
            return controls;
        }
        public async Task<bool> ValidateAsync()
        {
            var result = true;
            foreach (var control in GetAllControls())
            {
                if (control is IValidatable)
                {
                    var vcontrol = control as IValidatable;
                    result &= await vcontrol.ValidateAsync();
                }
            }

            return result;

        }

        protected virtual  void FormBase_LoadAsync(object sender, EventArgs e)
        {

        }

        private void FormBase_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12 && e.Shift)
                StyleManager.Theme = StyleManager.Theme == MetroThemeStyle.Dark ? MetroThemeStyle.Light : MetroThemeStyle.Dark;
        }

        protected virtual async void FormBase_ShownAsync(object sender, EventArgs e)
        {
            Application.DoEvents();
            foreach (var item in GetAllControls(null, null))
                if (item is IMetroControl)
                    (item as IMetroControl).StyleManager = MetroStyleManager;

            await FormLoadAsync();
            await FormAfterLoadAsync();
        }
    }
}
