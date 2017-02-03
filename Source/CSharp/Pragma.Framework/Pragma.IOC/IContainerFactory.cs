using Pragma.Abstraction;
using Pragma.Abstraction.IOC;
using Pragma.Core;


namespace Pragma.IOC
{
    public interface IContainerFactory : IFactory<IContainer>
    {
        IContainer GetDryIocImplementation();
        IContainer GetImplementation(IBinder[] binders);
    }
}