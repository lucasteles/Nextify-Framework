using Pragma.Core;
using System;

namespace Pragma.IOC
{
    public class ContainerFactory : IFactory<IContainer>
    {
        public static IContainer Container;

        public IContainer GetImplementation()
        {
            return GetDryIocImplementation();
        }

        public IContainer GetImplementation(int option)
        {
            throw new NotImplementedException();
        }

        public static IContainer GetDryIocImplementation()
        {
            var dic = new DryIocContainer();

            dic.Register<IContainer, DryIocContainer>(Lifecircle.Singleton);
            Container = dic;
            return dic;

        }

    }
}
