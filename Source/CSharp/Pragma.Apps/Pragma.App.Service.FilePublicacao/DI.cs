using Pragma.IOC;
using System;

namespace Pragma.App.Service.FilePublicacao.Tools
{
    public class DI
    {
        public static IContainer Container { get; set; }

        public static T Resolve<T>() => Container.Resolve<T>();

        public static object Resolve(Type type) => Container.Resolve(type);

    }
}
