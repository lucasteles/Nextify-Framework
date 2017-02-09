using Nextify.Abstraction.Forms.Controllers;
using Nextify.App.Business;
using Nextify.App.Forms.Controllers.F4;
using Nextify.App.Forms.Controllers.ItemsContainer;
using Nextify.App.Models;
using Nextify.Forms.Controllers;
using Nextify.Forms.Controls.Forms;
using System;
using System.Threading.Tasks;

namespace Nextify.App.Forms
{
    public partial class CoursesEdit : FormEdit
    {
        IEditController<Course> Controller;
        ICoursesBusiness Business;
        IAuthorF4Controller AuthorF4;
        ITagsItensContainerController TagsContainer;
        ITagBusiness TagBusiness;

        public CoursesEdit(
            IEditController<Course> _controller,
            ICoursesBusiness _business,
            ITagsItensContainerController _tagsContainer,
            IAuthorF4Controller _authorF4,
            ITagBusiness _tagBusiness
         )
        {
            InitializeComponent();
            Controller = _controller;
            Business = _business;
            TagsContainer = _tagsContainer;
            AuthorF4 = _authorF4;
            TagBusiness = _tagBusiness;


            TagsContainer.HasEdit = false;
        }

        public async override Task FormLoadAsync()
        {
           var binder = await Controller.UseAsync(this, Business);

            binder
              .Bind(e => e.Name, txtName)
              .Bind(e => e.FullPrice, txtPrice)
              .Bind(e => e.Level, txtLevel)

              .Bind(e => e.Author, f4Author)
              .Bind(e => e.Tags, cntTags);


            var authorBinder = await AuthorF4.UseAsync(f4Author);
            authorBinder
                .Bind(e => e.Name, txtAuthorName);


            
            await TagsContainer.UseAsync(cntTags);
            
            TagsContainer.GetEditFormAction = () =>
            {
                var resolver = DI.Resolve<Func<ITagBusiness, TagCourseEdit>>();
                return resolver(TagBusiness);
            };

        }

       
    }
}
