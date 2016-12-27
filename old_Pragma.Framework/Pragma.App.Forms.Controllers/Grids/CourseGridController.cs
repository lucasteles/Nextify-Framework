using Pragma.App.Business;
using Pragma.App.Models;
using Pragma.Core;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            // menu de contexto
            AddMenu(new Dictionary<string, Action>
            {
                ["Vai"] = () => MessageBox.Show("vai"),

            });


            // formatação

            var redIfZeroFormat = new ModelFormat()
            {
                ForeColor = Color.White,
                BackColor = Color.DarkRed,
                Bold = true
            };

            AddFormat(redIfZeroFormat, (m, i, p) => m.FullPrice < 0 && p == nameof(m.FullPrice));

        }



    }
}
