using Nextify.Abstraction.IOC;
using Nextify.Abstraction.Scheduling;
using Nextify.App.Binding;
using Nextify.App.Mapping;
using Nextify.App.Scheduling;
using Nextify.IOC;
using Nextify.Scheduling;
using System.Windows.Forms;

namespace Nextify.App.Forms.Tools
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
