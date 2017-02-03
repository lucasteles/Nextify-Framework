using ModelViewBinder;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls.Abstraction
{

    public interface IF4Controller<TModel>
    {
        TModel Model { get; set; }

        Task<IModelViewBinder<TModel>> UseAsync(PragmaF4TextBox textbox);

    }
}
