using Pragma.Abstraction.Forms.Controllers;
using Pragma.Core;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pragma.Abstraction.Forms.Controls
{
    public interface IPragmaItemsContainer : IControl
    {
        event EventHandler OnGetValue;
        event EventHandler OnSetValue;

        Form ParentForm { get;  }
    }


    public interface IPragmaItemsContainerController
    {
        bool HasAdd { get; set; }
        bool HasEdit { get; set; }
        bool HasRemove { get; set; }

        Task AddAsync();
        Task EditAsync();
        Task RemoveAsync();
        void SetFormEdit<TForm>() where TForm : IFormEdit;
        Task UseAsync(IPragmaItemsContainer items);
    }
}
