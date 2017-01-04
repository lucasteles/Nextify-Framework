using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Pragma.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsGenericTypeAssignableFrom<T>(this Type type)
        {
            return IsGenericTypeAssignableFrom(type, typeof(T));
        }
        public static bool IsGenericTypeAssignableFrom(this Type type, Type assignedType)
        {
            var result = type.GetInterfaces().Any((Type e) => e.IsGenericType && (e.IsAssignableFrom(assignedType)) ||
                    type.IsAssignableFrom(assignedType));

            return result;
        }
        public static TAttribute GetCustomAttribute<TAttribute>(this Type type, string propertyName)
        {
            return type.GetProperty(propertyName)
                                    .GetCustomAttributes(typeof(TAttribute), false)
                                    .Cast<TAttribute>().SingleOrDefault();
        }
        public static object GetKeyAtributteValue(this object type)
        {
            var key = type.GetType()
                .GetProperties()
                .FirstOrDefault(p => p.GetCustomAttributes(typeof(KeyAttribute), true).Length != 0);

            if (key == null)
                throw new Exception("Model dont implements Key attribute");

            return key.GetValue(type, null);
        }
        public static object GetPropertyValue(this object obj, string proper)
        {
            var key = obj.GetType()
                .GetProperty(proper);

            return key != null ? key.GetValue(obj, null) : null;
        }
        public static PropertyInfo[] GetPropertyInfosIncludingBaseClasses(this Type type)
        {
            var fieldInfos = type.GetProperties();

            // If this class doesn't have a base, don't waste any time
            if (type.BaseType == typeof(object))
                return fieldInfos;
            else
            {   // Otherwise, collect all types up to the furthest base class
                var currentType = type;
                var fieldComparer = new PropertyInfoComparer();
                var fieldInfoList = new HashSet<PropertyInfo>(fieldInfos, fieldComparer);
                while (currentType != typeof(object))
                {
                    fieldInfos = currentType.GetProperties();
                    fieldInfoList.UnionWith(fieldInfos);
                    currentType = currentType.BaseType;
                }
                return fieldInfoList.ToArray();
            }
        }
        /// <summary>
        /// Faz a comparação das propriedades e valida se todas estão iguais.
        /// </summary>
        /// <typeparam name="T">Tipo do objeto</typeparam>
        /// <param name="tSelf">Objeto atual</param>
        /// <param name="tObj">Objeto de comparação</param>
        /// <param name="tIgnore">Propriedades que devem ser ignoradas</param>
        /// <returns>retorna true se todos forem iguais</returns>
        public static bool PropertiesEqual<T>(this T tSelf, T tObj, params string[] tIgnore)
        {
            if (tSelf != null && tObj != null)
            {
                var type = tSelf.GetType();
                var ignoreList = new List<string>(tIgnore);
                var ListProp = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                // se nao existe propriedades, considera como iguais
                if (ListProp.Length == 0)
                    return true;

                foreach (PropertyInfo pi in ListProp)
                {
                    // verifica se a propriedades está na lista dos ignorados
                    if (!ignoreList.Contains(pi.Name))
                    {
                        var selfValue = type.GetProperty(pi.Name).GetValue(tSelf, null);
                        var toValue = type.GetProperty(pi.Name).GetValue(tObj, null);

                        if (selfValue != toValue && (selfValue == null || !selfValue.Equals(toValue)))
                            if (!selfValue.GetType().IsGenericType)
                                return false;
                    }
                }
            }
            return true;
        }
        private class PropertyInfoComparer : IEqualityComparer<PropertyInfo>
        {
            public bool Equals(PropertyInfo x, PropertyInfo y)
            {
                return x.DeclaringType == y.DeclaringType && x.Name == y.Name;
            }
            public int GetHashCode(PropertyInfo obj)
            {
                return obj.Name.GetHashCode() ^ obj.DeclaringType.GetHashCode();
            }
        }
    }
}