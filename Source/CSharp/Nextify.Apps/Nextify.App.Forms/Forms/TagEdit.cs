using Nextify.Abstraction.Forms.Controllers;
using Nextify.App.Business;
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
    
    public partial class TagEdit : FormEdit
    {
        readonly IEditController<Tag> Controller;
        readonly ITagBusiness Business;

        public TagEdit(
            IEditController<Tag> controller,
            ITagBusiness business
            ) 
        {
            InitializeComponent();
            Controller = controller;
            Business = business;
        }


        public async override Task FormLoadAsync()
        {
            var binder = await Controller.UseAsync(this, Business);
            binder.Bind(e => e.Name, txtName);

        }


    }
}
