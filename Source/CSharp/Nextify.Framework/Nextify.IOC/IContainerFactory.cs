using Nextify.Abstraction;
using Nextify.Abstraction.IOC;
using Nextify.Core;


namespace Nextify.IOC
{
    public interface IContainerFactory : IFactory<IContainer>
    {
        IContainer GetDryIocImplementation();
        IContainer GetImplementation(IBinder[] binders);
    }
}