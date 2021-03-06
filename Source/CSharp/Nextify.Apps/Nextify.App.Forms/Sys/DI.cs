﻿using Nextify.Abstraction.IOC;
using Nextify.Forms.Controls.Forms;
using Nextify.IOC;
using System;
using System.Windows.Forms;

namespace Nextify.App.Forms
{
    public class DI
    {
        public static IContainer Container { get; set; }

        public static T Resolve<T>() => Container.Resolve<T>();

        public static object Resolve(Type type) => Container.Resolve(type);

        public static T ShowForm<T>() where T : Form
        {
            var form =  Container.Resolve<T>();
            form.Show();
            return form;
        }

    }
}
