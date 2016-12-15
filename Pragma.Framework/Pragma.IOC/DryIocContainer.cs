using DryIoc;
using Pragma.Extensions;
using Pragma.IOC.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Pragma.IOC
{
    public class DryIocContainer : IContainer
    {
        private Container _container;

        private IDictionary<Lifecircle, IReuse> reuseSwitch;

        public DryIocContainer()
        {
            reuseSwitch = new Dictionary<Lifecircle, IReuse>()
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
                    Assembly.GetEntryAssembly()
                    .GetTypes()
                    .Where(e => e == type || e.MyIsAssignableFrom(type))
            );


        }

        public void RegisterMany(Type type)
        {
            _container.RegisterMany(
                 Assembly.GetEntryAssembly()
                 .GetTypes()
                 .Where(e => e == type || e.MyIsAssignableFrom(type))
         );


        }
    }

}





