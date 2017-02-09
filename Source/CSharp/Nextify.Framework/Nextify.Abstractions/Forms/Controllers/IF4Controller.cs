using ModelViewBinder;
using System.Threading.Tasks;

namespace Nextify.Abstraction.Forms.Controls.Abstraction
{

    public interface INextifyF4TextBox : IControl
    {

    }

    public interface IF4Controller<TModel>
    {
        TModel Model { get; set; }

        Task<IModelViewBinder<TModel>> UseAsync(INextifyF4TextBox textbox);

    }
}
