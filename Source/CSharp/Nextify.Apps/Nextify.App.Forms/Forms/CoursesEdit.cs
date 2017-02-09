using Nextify.Abstraction.Forms.Controllers;
using Nextify.App.Business;
using Nextify.App.Forms.Controllers.F4;
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
        IAuthorF4Controller AuthorF4;

        public CoursesEdit(
            IEditController<Course> _controller,
            ICoursesBusiness _business,

            IAuthorF4Controller _authorF4
         )
        {
            InitializeComponent();
            Controller = _controller;
            Business = _business;

            AuthorF4 = _authorF4;

        }

        public async override Task FormLoadAsync()
        {
           var binder = await Controller.UseAsync(this, Business);

            binder
              .Bind(e => e.Name, txtName)
              .Bind(e => e.FullPrice, txtPrice)
              .Bind(e => e.Level, txtLevel)
              
              .Bind(e=>e.Author, f4Author);


            var authorBinder = await AuthorF4.UseAsync(f4Author);

            authorBinder
                .Bind(e => e.Name, txtAuthorName);

        }


    }
}
