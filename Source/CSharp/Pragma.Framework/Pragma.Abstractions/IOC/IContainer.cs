
using Pragma.Core;
using System;
using System.Collections.Generic;
using System.Web.Http;


namespace Pragma.Abstraction.IOC
{
    public interface IContainer
    {
        bool IsRegistered(Type T, object serviceKey = null);
        bool IsRegistered<T>(object serviceKey = null);
        void Register(Type type, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null);
        void Register(Type service, Type implementation, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null);
        void Register<T>(Lifecircle reuse = Lifecircle.Transient, object serviceKey = null);
        void Register<TService, TImplementation>(Lifecircle reuse = Lifecircle.Transient, object serviceKey = null) where TImplementation : TService;
        void RegisterBinders(params IBinder[] binders);
        void RegisterDelegate(Type type, Func<IContainer, object> factoryDelegate, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null);
        void RegisterDelegate<TService>(Func<IContainer, TService> factoryDelegate, Lifecircle reuse = Lifecircle.Transient, object serviceKey = null);
        void RegisterMany(Type type);
        void RegisterMany<T>();
        object Resolve(Type type, object serviceKey = null);
        T Resolve<T>(object serviceKey = null);
        IEnumerable<object> ResolveMany(Type type);
        IEnumerable<T> ResolveMany<T>();
        void WithWebApi(HttpConfiguration config);
    }
}