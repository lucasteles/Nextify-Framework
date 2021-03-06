﻿using Nextify.Abstraction;
using ModelViewBinder;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nextify.Core;

namespace Nextify.Abstraction.Forms.Controls
{
    public interface IValidatable
    {
        Task<bool> ValidateAsync();

        bool IsValid();

    }

    public interface IControl : IBindableComponent, ITargetWithValue, IValidatable
    {

        /// <summary>
        /// Indica se o campo é obrigatório.
        /// </summary>
        [Description("Indica se o campo é obrigatorio")]
        bool Required { get; set; }

        void ShowTootipMessage(string message, FailureSeverity severity, string title);

        void ShowTootipMessage(string message, FailureSeverity severity, string title, int time);

        /// <summary>
        /// Retorna se o campo está vazio.
        /// </summary>
        /// <returns>Booleano indicando se está vazio.</returns>
        bool IsEmpty();

    }

}
