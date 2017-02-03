using Pragma.Abstraction;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.Core
{
    public abstract class BaseModel : IBase
    {
        public bool Inative { get; set; }

        public int? Owner { get; set; }


        public DateTime? Created { get; set; }


        public DateTime? Updated { get; set; }

        

    }
}
