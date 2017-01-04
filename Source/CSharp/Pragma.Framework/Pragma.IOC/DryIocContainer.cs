using DryIoc;
using Pragma.IOC.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pragma.IOC
{
    public class DryIocContainer : IContainer
    {
        private readonly Container _container;

        private readonly IDictionary<Lifecircle, IReuse> reuseSwitch;

        public DryIocContainer()
        {
            reuseSwitch = new Dictionary<Lifecircle, IReuse>
            {
                [Lifecircle.Transient] = Reuse.Transient,
                [Lifecircle.Singleton] = Reuse.Singleton,
                [Lifecircle.InWebRequest] = Reuse.InWebRequest,
                [Lifecircle.InResolutionScope] = Reuse.InResolutionScope,
            };

            _container = new Container(rules => rules.WithoutThrowOnRegisteringDisposableTransient());

        }

        public void RegisterBinders(params IBinder[] binders)
        {
            foreach (var item in binders)
                item.SetBinding(this);
        }

        public void Register<T>(Lifecircle reuse = Lifecircle.Transient)
        {
            _container.Register<T>(reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace);
        }

        public void Register(Type type, Lifecircle reuse = Lifecircle.Transient)
        {

            _container.Register(type, reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace);
        }

        public void Register<TService, TImplementation>(Lifecircle reuse = Lifecircle.Transient) where TImplementation : TService
        {
            _container.Register<TService, TImplementation>(reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace);
        }

        public void Register(Type service, Type implementation, Lifecircle reuse = Lifecircle.Transient)
        {
            _container.Register(service, implementation, reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace);
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void RegisterMany<T>()
        {

            var type = typeof(T);

            _container.RegisterMany(
                    GetAssemblyTypes(type)
            );

        }

        public void RegisterMany(Type type)
        {

            _container.RegisterMany(
                 GetAssemblyTypes(type)

         );

        }

        private static Type[] GetAssemblyTypes(Type type)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(e => e.FullName.Contains(nameof(Pragma)));
            var result = assemblies.SelectMany(e => e.GetTypes())
                         .Where(e => !e.IsAbstract && !e.IsInterface && !e.IsGenericType && e.GetAllConstructors().Count() <= 1)
                         .Where(e => e == type || e.IsAssignableTo(type))
                         .Distinct()
                         .ToArray();

            return result;
        }
    }

}


