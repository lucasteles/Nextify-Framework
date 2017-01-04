using Pragma.App.Forms.Controllers.Grids;
using Pragma.Forms.Controls.Forms;

namespace Pragma.App.Forms
{
    public partial class TestForm : FormConsult
    {
        public TestForm(IUsuarioLoginGridController controller) : base(controller)
        {

            InitializeComponent();
        }

    }
}
