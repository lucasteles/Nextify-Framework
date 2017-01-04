using System;

namespace Pragma.Core
{

    public interface IDisposeContainer : IDisposable
    {
        void RegisterDispose(IDisposable itemToDispose);
    }
}


