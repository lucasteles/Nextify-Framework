using Pragma.Core;
using System.Collections.Generic;

namespace Pragma.DAO.Abstraction
{
    public interface IContext
    {
        IEnumerable<IOperationResult> GetValidationErrors();

    }
}
