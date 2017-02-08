using Nextify.Abstraction;
using Nextify.Abstraction.IOC;
using Nextify.Core;


namespace Nextify.IOC
{
    public class ContainerFactory : IFactory<IContainer>, IContainerFactory
    {
        public static IContainer Instance;

        public IContainer GetDryIocImplementation()
        {

            Instance = new DryIocContainer();
            Instance.RegisterDelegate(
                    e =>
                    {
                        return Instance;
                    }
                , Lifecircle.Singleton);


            return Instance;

        }


        public IContainer GetImplementation(IBinder[] binders)
        {
            Instance = new DryIocContainer();
            Instance.RegisterBinders(binders);

            Instance.RegisterDelegate(
                    e =>
                    {
                        return Instance;
                    }
                , Lifecircle.Singleton);


            return Instance;

        }

        public IContainer GetImplementation()
        {
            return GetDryIocImplementation();
        }

        public IContainer GetImplementation(int option)
        {
            return GetImplementation();
        }

    }
}
