using Nextify.Abstraction;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nextify.Core
{
    public abstract class BaseModel : IBase
    {
        public bool Inative { get; set; }

       
        public DateTime? Created { get; set; }


        public DateTime? Updated { get; set; }

        

    }
}
