using System;
using System.Collections.Generic;
using System.Drawing;

namespace Nextify.Forms.Models
{
    public class NextifyMenuItem
    {
        public string Name { get; set; }
        //public virtual MenuItem MenuPai { get; set; }
        public List<NextifyMenuItem> ChildMenus { get; set; } = new List<NextifyMenuItem>();
        public int Order { get; set; }
        public Action ButtonAction { get; set; }
        public Bitmap Icon { get; set; }
    }
}
