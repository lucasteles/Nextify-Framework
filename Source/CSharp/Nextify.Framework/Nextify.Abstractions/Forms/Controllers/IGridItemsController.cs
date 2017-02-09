using Nextify.Abstraction.Forms.Controllers;
using Nextify.Abstraction.Forms.Controls;
using Nextify.Core;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nextify.Abstraction.Forms.Controller
{
    public interface INextifyItemsContainer : IControl
    {
        event EventHandler OnGetValue;
        event EventHandler OnSetValue;

        Form ParentForm { get;  }
    }


    public interface IItemsContainerController
    {
        bool HasAdd { get; set; }
        bool HasEdit { get; set; }
        bool HasRemove { get; set; }
        Func<IFormEdit> GetEditFormAction { get; set; }

        Task AddAsync();
        Task EditAsync();
        Task RemoveAsync();
        void SetFormEdit<TForm>() where TForm : IFormEdit;
        Task UseAsync(INextifyItemsContainer items);
    }
}
