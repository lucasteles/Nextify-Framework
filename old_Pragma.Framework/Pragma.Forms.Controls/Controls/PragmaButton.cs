using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls.Controls
{
    public partial class PragmaButton : MetroButton
    {
        public PragmaButton()
        {
            InitializeComponent();
        }

        public PragmaButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
