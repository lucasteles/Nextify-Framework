using Nextify.Abstraction.Forms.Controllers;
using Nextify.App.Business;
using Nextify.App.Models;
using Nextify.Forms.Controllers;
using Nextify.Forms.Controls.Forms;
using System.Threading.Tasks;

namespace Nextify.App.Forms
{
    public partial class CoursesEdit : FormEdit
    {
        IEditController<Course> Controller;
        ICoursesBusiness Business;

        public CoursesEdit(
            IEditController<Course> _controller,
            ICoursesBusiness _business
         )
        {
            InitializeComponent();
            Controller = _controller;
            Business = _business;

        }

        public async override Task FormLoadAsync()
        {
           var bind = await Controller.UseAsync(this, Business);

            bind
              .Register(e => e.Name, txtName)
              .Register(e => e.FullPrice, txtPrice)
              .Register(e => e.Level, txtLevel);


        }


    }
}
