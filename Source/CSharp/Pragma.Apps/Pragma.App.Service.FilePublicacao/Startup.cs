using Pragma.App.Binding;
using Pragma.App.Mapping;
using Pragma.App.Scheduling;
using Pragma.IOC;
using Pragma.Scheduling;
using System.Windows.Forms;

namespace Pragma.App.Service.FilePublicacao.Tools
{
    public class Startup
    {
        public static void Start()
        {
            var binder = new BinderRegister();

            DI.Container = new ContainerFactory().GetImplementation();
            binder.RegisterBinders(DI.Container);

            DI.Container.Register<IGuiaInvestimentos, GuiaInvestimentos>();

            var _container = DI.Container.Resolve<IContainer>();
            binder.RegisterBinders(_container);

            MapperConfiguration.RegisterAllProfiles();
        }
    }
}
