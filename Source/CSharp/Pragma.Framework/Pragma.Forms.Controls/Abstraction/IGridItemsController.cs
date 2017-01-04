using Pragma.Forms.Controls.Forms;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls.Abstraction
{
    public interface IPragmaItemsContainerController
    {
        bool HasAdd { get; set; }
        bool HasEdit { get; set; }
        bool HasRemove { get; set; }

        Task AddAsync();
        Task EditAsync();
        Task RemoveAsync();
        void SetFormEdit<TForm>() where TForm : FormEdit;
        Task UseAsync(PragmaItemsContainer items);
    }
}
