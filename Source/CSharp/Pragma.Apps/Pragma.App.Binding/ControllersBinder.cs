
using Pragma.App.Forms.Controllers.Combos;
using Pragma.App.Forms.Controllers.F4;
using Pragma.App.Forms.Controllers.GridItems;
using Pragma.App.Forms.Controllers.Grids;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

namespace Pragma.App.Binding
{
    public class ControllersBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            container.Register<IUsuarioLoginF4Controller, UsuarioLoginF4Controller>();
            container.Register<IUsuarioLoginGridController, UsuarioLoginGridController>();
            container.Register<IConnectionComboController, ConnectionComboController>();
            container.Register<IUsuarioGridItemsController, UsuarioGridItemsController>();
            container.Register<IXMLFilesGridController, XMLFilesGridController>();
            container.Register<IUserDTOGridController, UserDTOGridController>();

        }

    }
}
