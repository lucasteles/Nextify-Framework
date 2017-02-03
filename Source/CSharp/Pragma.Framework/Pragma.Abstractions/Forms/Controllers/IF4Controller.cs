using ModelViewBinder;
using System.Threading.Tasks;

namespace Pragma.Abstraction.Forms.Controls.Abstraction
{

    public interface IPragmaF4TextBox
    {

    }

    public interface IF4Controller<TModel>
    {
        TModel Model { get; set; }

        Task<IModelViewBinder<TModel>> UseAsync(IPragmaF4TextBox textbox);

    }
}
