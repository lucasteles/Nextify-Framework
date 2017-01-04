﻿using Pragma.Core;
using Pragma.Forms.Controls.Abstraction;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public static class ControlExtensions
    {
        private delegate void SetPropertyThreadSafeDelegate<TResult>(
            Control @this,
            Expression<Func<TResult>> property,
            TResult value);

        public static void SetPropertyThreadSafe<TResult>(
            this Control @this,
            Expression<Func<TResult>> property,
            TResult value)
        {
            var propertyInfo = (property.Body as MemberExpression).Member
                as PropertyInfo;

            if (propertyInfo == null ||
                !@this.GetType().IsSubclassOf(propertyInfo.ReflectedType) ||
                @this.GetType().GetProperty(
                    propertyInfo.Name,
                    propertyInfo.PropertyType) == null)
            {
                throw new ArgumentException("The lambda expression 'property' must reference a valid property on this Control.");
            }

            if (@this.InvokeRequired)
            {
                @this.Invoke(new SetPropertyThreadSafeDelegate<TResult>
                (SetPropertyThreadSafe),
                new object[] { @this, property, value });
            }
            else
            {
                @this.GetType().InvokeMember(
                    propertyInfo.Name,
                    BindingFlags.SetProperty,
                    null,
                    @this,
                    new object[] { value });
            }

        }

        public static void SetBgColor(this Control control)
        {
            if (!(typeof(IControl).IsAssignableFrom(control.GetType()) && typeof(Control).IsAssignableFrom(control.GetType())))
                return;

            var pgmControl = (IControl)control;
            var baseControl = control;
            if (!baseControl.Enabled)
                baseControl.BackColor = PragmaColor.CinzaDisabled;
            else if (!pgmControl.IsValid())
                baseControl.BackColor = PragmaColor.VermelhoError;
            else if (pgmControl.Required)
                baseControl.BackColor = PragmaColor.AmareloAlert;
            else
                baseControl.BackColor = PragmaColor.Branco;
        }

    }
}
