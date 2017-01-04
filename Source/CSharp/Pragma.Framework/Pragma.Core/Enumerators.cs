namespace Pragma.Core

{

    /// <summary>
    /// Tipos de controles utilizados nas grades
    /// </summary>
    public enum ControlType
    {
        TextBox,
        TextBoxEdit,
        CheckBox,
        ComboBox
    }

    /// <summary>
    /// Nível de Severidade do ValidationFailure
    /// </summary>
    public enum FailureSeverity
    {

        Info = 1,
        Warning = 2,
        Error = 3
    }

}
