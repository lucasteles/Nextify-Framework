using System;

namespace  Pragma.Abstraction
{

    public interface IDisposeContainer : IDisposable
    {
        void RegisterDispose(IDisposable itemToDispose);
    }
}


