using FluentValidation;
using Pragma.Core;
using Pragma.DAO.Abstraction;
using Pragma.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Business.Abstraction

{
    public abstract class Business  
    {
     

        protected static IOperationResult BadResult(params string[] Messages)
        {
            return OperationResult.BadResult(Messages);

        }

        protected static IOperationResult CreateResult(bool valid, FailureSeverity severity, params string[] messages)
        {
            return OperationResult.CreateResult(valid, severity, messages );
        }

        protected static IOperationResult CreateResult(bool valid, params string[] messages)
        {
            return OperationResult.CreateResult(valid, FailureSeverity.Warning , messages);

        }

        protected static IOperationResult CreateResult(bool valid, params IErrorMessage[] messages)
        {
            return OperationResult.CreateResult(valid, messages);
           
        }

        protected static IOperationResult Ok()
        {
            return OperationResult.Ok();
        }
      
    }
}
