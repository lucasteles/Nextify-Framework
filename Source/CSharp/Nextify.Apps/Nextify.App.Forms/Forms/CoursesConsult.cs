
using Nextify.App.Business;
using Nextify.App.Forms.Controllers;
using Nextify.App.Models;
using Nextify.Forms.Controls.Forms;
using Nextify.IOC;

namespace Nextify.App.Forms
{
    public partial class CoursesConsult : FormConsult
    {


        public CoursesConsult(
                ICourseGridController controller
            ) : base(controller)
        {
            HasDelete = true;
            
            SetFormEdit<CoursesEdit>();

            InitializeComponent();
        }



    }
}
