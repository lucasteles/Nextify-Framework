using Pragma.Abstraction.IOC;
using Pragma.Abstraction.Scheduling;
using Pragma.App.Binding;
using Pragma.App.Mapping;
using Pragma.App.Scheduling;
using Pragma.IOC;
using Pragma.Scheduling;
using System.Windows.Forms;

namespace Pragma.App.Forms.Tools
{
    public class Startup
    {
        public static void Start()
        {
            var binder = new BinderRegister();

            DI.Container = new ContainerFactory().GetImplementation();
            binder.RegisterBinders(DI.Container);

            var _container = DI.Container.Resolve<IContainer>();
            binder.RegisterBinders(_container);

            DI.Container.RegisterMany<Form>();
            _container.RegisterMany<Form>();

            MapperConfiguration.RegisterAllProfiles();

            var scheduler = DI.Container.Resolve<IScheduleManager>();
            scheduler.Start(DI.Container, new ScheduleRegister());
        }
    }
}
