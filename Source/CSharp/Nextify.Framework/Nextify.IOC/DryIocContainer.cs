using Nextify.Abstraction.IOC;
using DryIoc;
using DryIoc.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Nextify.Core;

namespace Nextify.IOC
{
    public class DryIocContainer : Abstraction.IOC.IContainer
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


        public bool IsRegistered<T>(object serviceKey = null) => _container.IsRegistered<T>(serviceKey);

        public bool IsRegistered(Type T, object serviceKey = null) => _container.IsRegistered(T, serviceKey);

        public void Register<T>(Lifecircle reuse = Lifecircle.Transient, object serviceKey = null)
        {
            _container.Register<T>(reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: serviceKey, made: FactoryMethod.ConstructorWithResolvableArguments);
        }

        public void Register(Type type, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null)
        {

            _container.Register(type, reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: serviceKey, made: FactoryMethod.ConstructorWithResolvableArguments);
        }

        public void Register<TService, TImplementation>(Lifecircle reuse = Lifecircle.Transient, object serviceKey = null) where TImplementation : TService
        {
            _container.Register<TService, TImplementation>(reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: serviceKey, made: FactoryMethod.ConstructorWithResolvableArguments);
        }

        public void Register(Type service, Type implementation, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null)
        {
            _container.Register(service, implementation, reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: serviceKey, made: FactoryMethod.ConstructorWithResolvableArguments);
        }

        public void RegisterBinders(params IBinder[] binders)
        {
            foreach (var item in binders)
                item.SetBinding(this);
        }

        public void RegisterDelegate<TService>(Func<Abstraction.IOC.IContainer, TService> factoryDelegate, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null)
        {
            var handler = factoryDelegate;
            if (handler != null)
                _container.RegisterDelegate((e) => handler(this), reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: serviceKey);
        }

        public void RegisterDelegate(Type type, Func<Abstraction.IOC.IContainer, object> factoryDelegate, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null)
        {
            _container.RegisterDelegate(type, (e) => factoryDelegate?.Invoke(this), reuseSwitch[reuse], ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: serviceKey);
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

        public T Resolve<T>(object serviceKey = null)
        {
            return _container.Resolve<T>(serviceKey: serviceKey);
        }

        public object Resolve(Type type, object serviceKey = null)
        {
            return _container.Resolve(type, serviceKey: serviceKey);
        }


        public IEnumerable<T> ResolveMany<T>()
        {
            return _container.ResolveMany<T>();
        }

        public IEnumerable<object> ResolveMany(Type type)
        {
            return _container.ResolveMany(type);
        }

        public void WithWebApi(HttpConfiguration config)
        {
            _container
              .WithWebApi(config);
        }

        private static Type[] GetAssemblyTypes(Type type)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(e => e.FullName.Contains(nameof(Nextify)));
            var result = assemblies.SelectMany(e => e.GetTypes())
                         .Where(e => !e.IsAbstract && !e.IsInterface && !e.IsGenericType && e.GetAllConstructors().Count() <= 1)
                         .Where(e => e == type || e.IsAssignableTo(type))
                         .Distinct()
                         .ToArray();

            return result;
        }
    }


}


