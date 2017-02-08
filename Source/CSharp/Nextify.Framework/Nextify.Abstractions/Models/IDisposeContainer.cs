using System;

namespace  Nextify.Abstraction
{

    public interface IDisposeContainer : IDisposable
    {
        void RegisterDispose(IDisposable itemToDispose);
    }
}


