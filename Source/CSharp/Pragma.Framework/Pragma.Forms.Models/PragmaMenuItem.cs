using System;
using System.Collections.Generic;
using System.Drawing;

namespace Pragma.Forms.Models
{
    public class PragmaMenuItem
    {
        public string Name { get; set; }
        //public virtual MenuItem MenuPai { get; set; }
        public List<PragmaMenuItem> ChildMenus { get; set; } = new List<PragmaMenuItem>();
        public int Order { get; set; }
        public Action ButtonAction { get; set; }
        public Bitmap Icon { get; set; }
    }
}
