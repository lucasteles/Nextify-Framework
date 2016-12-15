using Pragma.Core;
using Pragma.Forms.ControlBinding.Abstraction;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Forms.Controls.Abstraction
{
    public interface IControl : IBindableComponent, IControlWithValue
    {

        /// <summary>
        /// Indica se o campo é obrigatório.
        /// </summary>
        [Description("Indica se o campo é obrigatorio")]
        bool Required { get; set; }


        void ShowTootipMessage(string message, FailureSeverity severity, string title = "");

        /// <summary>
        /// Retorna se o campo está vazio.
        /// </summary>
        /// <returns>Booleano indicando se está vazio.</returns>
        bool IsEmpty();

        Task<bool> Validate();

        bool IsValid();

    }

}
