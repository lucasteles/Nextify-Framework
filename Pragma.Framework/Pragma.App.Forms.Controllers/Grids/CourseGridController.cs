using Pragma.App.Business;
using Pragma.App.Models;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pragma.App.Forms.Controllers
{
    public interface ICourseGridController : IGridController<CourseDTO>
    {

    }

    public class CourseGridController : GridViewController<Course, CourseDTO>, ICourseGridController
    {
        public CourseGridController(ICoursesBusiness business) : base(business)
        {

            AddMenu(new Dictionary<string, Action>
            {
                ["Vai"] = () => MessageBox.Show("vai"),

            });
        }



    }
}
