using Nextify.Abstraction.Forms.Controllers;
using Nextify.App.Business;
using Nextify.App.Forms.Controllers.F4;
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
    
    public partial class TagCourseEdit : FormEdit
    {
        readonly IEditController<Tag> Controller;
        readonly ITagBusiness Business;
        readonly ITagF4Controller TagF4Controller;

        public TagCourseEdit(
            IEditController<Tag> controller,
            ITagBusiness business,
            Func<ITagBusiness,ITagF4Controller> f4Controller
            ) 
        {
            PersistData = false;
            InitializeComponent();
            Controller = controller;
            Business = business;
            TagF4Controller = f4Controller(business);
        }


        public async override Task FormLoadAsync()
        {
              await Controller.UseAsync(this, Business);

              var binder = await TagF4Controller.UseAsync(f4Tag);
                binder.Bind(e => e.Name, txtName);

              f4Tag.Value = Controller.Model;
              f4Tag.ValueChanged += (object sender, EventArgs e) =>
                   ItemsModel = Controller.Model = f4Tag.Value as Tag;
                ;

                
        }


    }
}
