using Pragma.Core;
using System;

namespace Pragma.IOC
{
    public class ContainerFactory : IFactory<IContainer>
    {
        public IContainer GetImplementation()
        {
            return GetDryIocImplementation();
        }

        public IContainer GetImplementation(int option)
        {
            throw new NotImplementedException();
        }

        public IContainer GetDryIocImplementation()
        {
            var dic = new DryIocContainer();

            dic.Register<IContainer, DryIocContainer>(Lifecircle.Singleton);

            return dic;

        }


    }
}
