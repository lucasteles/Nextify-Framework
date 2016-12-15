using Pragma.IOC.Abstraction;
using System;

namespace Pragma.IOC
{
    public interface IContainer
    {
        void Register(Type type, Lifecircle reuse = Lifecircle.Transient);
        void Register<T>(Lifecircle reuse = Lifecircle.Transient);

        void Register<TService, TImplementation>(Lifecircle reuse = Lifecircle.Transient) where TImplementation : TService;

        void Register(Type service, Type implementation, Lifecircle reuse = Lifecircle.Transient);

        void RegisterMany<T>();

        void RegisterMany(Type type);

        void RegisterBinders(params IBinder[] binders);
        T Resolve<T>();
        object Resolve(Type type);
    }
}