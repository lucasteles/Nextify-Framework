using Pragma.App.Forms.Controllers;
using Pragma.Forms.Controls.Forms;
using Pragma.IOC;

namespace Pragma.App.Forms
{
    public partial class CoursesConsult : FormConsult
    {


        public CoursesConsult(
                ICourseGridController controller,
                IContainer container

            ) : base(controller, container)
        {



            SetFormEdit<CoursesEdit>();

            InitializeComponent();
        }



    }
}
