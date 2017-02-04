
using Pragma.App.Forms.Controllers;
using Pragma.Forms.Controls.Forms;
using Pragma.IOC;

namespace Pragma.App.Forms
{
    public partial class CoursesConsult : FormConsult
    {


        public CoursesConsult(
                ICourseGridController controller
            ) : base(controller)
        {
            
            SetFormEdit<CoursesEdit>();

            InitializeComponent();
        }



    }
}
