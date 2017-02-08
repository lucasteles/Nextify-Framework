using Nextify.Abstraction;
using Nextify.Core;
using System.Collections.Generic;

namespace Nextify.Abstraction.DAO
{
    public interface IContext
    {
        IEnumerable<IOperationResult> GetValidationErrors();

    }
}
