using Pragma.Core;
using Pragma.IOC.Abstraction;

namespace Pragma.IOC
{
    public interface IContainerFactory : IFactory<IContainer>
    {
        IContainer GetDryIocImplementation();
        IContainer GetImplementation(IBinder[] binders);
    }
}