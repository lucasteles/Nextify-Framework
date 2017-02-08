using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Nextify.Extensions
{
    public static class ExpressionExtensions
    {

        public static string MemberName<T, V>(this Expression<Func<T, V>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new InvalidOperationException("Expression must be a member expression");

            return memberExpression.Member.Name;
        }

        public static PropertyInfo GetPropertyInfo<T, V>(this Expression<Func<T, V>> expression)
        {
            PropertyInfo property;

            var exp = expression.Body as MemberExpression;
            if (exp == null)
                exp = ((UnaryExpression)expression.Body).Operand as MemberExpression;
            property = (PropertyInfo)exp.Member;

            return property;
        }

        public static T GetAttribute<T>(this ICustomAttributeProvider provider)
            where T : Attribute
        {
            var attributes = provider.GetCustomAttributes(typeof(T), true);
            return attributes.Length > 0 ? attributes[0] as T : null;
        }

        public static DisplayAttribute GetDisplayAttribute<T, V>(this Expression<Func<T, V>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
                throw new InvalidOperationException("Expression must be a member expression");

            return memberExpression.Member.GetAttribute<DisplayAttribute>();
        }

        public static string GetDisplayName<T, V>(this T obj, Expression<Func<T,V>> expression)
        {
            return expression.GetDisplayAttribute()?.Name;
        }


       public static IEnumerable<MemberExpression> GetMemberExpressions(this Expression body)
        {
            // A Queue preserves left to right reading order of expressions in the tree
            var candidates = new Queue<Expression>(new[] { body });
            while (candidates.Count > 0)
            {
                var expr = candidates.Dequeue();
                if (expr is MemberExpression)
                {
                    yield return ((MemberExpression)expr);
                }
                else if (expr is UnaryExpression)
                {
                    candidates.Enqueue(((UnaryExpression)expr).Operand);
                }
                else if (expr is BinaryExpression)
                {
                    var binary = expr as BinaryExpression;
                    candidates.Enqueue(binary.Left);
                    candidates.Enqueue(binary.Right);
                }
                else if (expr is MethodCallExpression)
                {
                    var method = expr as MethodCallExpression;
                    foreach (var argument in method.Arguments)
                    {
                        candidates.Enqueue(argument);
                    }
                }
                else if (expr is LambdaExpression)
                {
                    candidates.Enqueue(((LambdaExpression)expr).Body);
                }
            }
        }

     
    }

}   