using Pragma.Abstraction;
using Pragma.Core;
using System.Collections.Generic;

namespace Pragma.Abstraction.DAO
{
    public interface IContext
    {
        IEnumerable<IOperationResult> GetValidationErrors();

    }
}
