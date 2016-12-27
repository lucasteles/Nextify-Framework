
using Pragma.App.Binding;
using Pragma.App.Mapping;
using Pragma.App.Scheduling;
using Pragma.IOC;
using Pragma.Scheduling;
using System;

using System.Windows.Forms;

namespace Pragma.App.Forms
{
    public class DI
    {
        public static IContainer Container { get; }

        static DI()
        {
            var binder = new BinderRegister();

            Container = new ContainerFactory().GetImplementation();
            binder.RegisterBinders(Container);


            var _container = Container.Resolve<IContainer>();
            binder.RegisterBinders(_container);


            Container.RegisterMany<Form>();
            _container.RegisterMany<Form>();


            MapperConfiguration.RegisterAllProfiles();

            var scheduler = Resolve<IScheduleManager>();
            scheduler.Start(Container, new ScheduleRegister());
        }

        public static T Resolve<T>() => Container.Resolve<T>();

        public static object Resolve(Type type) => Container.Resolve(type);

    }
}
