using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Pragma.Extensions
{
    public static class TypeExtensions
    {
        public static bool MyIsAssignableFrom<T>(this Type type)
        {
            return MyIsAssignableFrom(type, typeof(T));
        }

        public static bool MyIsAssignableFrom(this Type type, Type assignedType)
        {
            return type.GetInterfaces().Any((Type e) => e.IsAssignableFrom(assignedType)) ||
                    type.IsAssignableFrom(assignedType);
        }

        public static TAttribute GetCustomAttribute<TAttribute>(this Type type, string propertyName)
        {
            return type.GetProperty(propertyName)
                                    .GetCustomAttributes(typeof(TAttribute), false)
                                    .Cast<TAttribute>().SingleOrDefault();
        }



        public static object GetKeyValue(this Type type, object item)
        {
            PropertyInfo key = type
                .GetProperties()
                .FirstOrDefault(p => p.GetCustomAttributes(typeof(KeyAttribute), true).Length != 0);

            return key != null ? key.GetValue(item, null) : null;
        }
    }
}