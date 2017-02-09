using Nextify.Abstraction.Forms.Controllers;
using Nextify.App.Forms.Controllers.Grids;
using Nextify.App.Models;
using Nextify.Forms.Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nextify.App.Forms
{
    public partial class AuthorConsult : FormConsult
    {
        

        public AuthorConsult(IAuthorGridController editController) : base(editController)
        {
            InitializeComponent();

            SetFormEdit<AuthorEdit>();
        }
    }
}
