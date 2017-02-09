using LinqKit;
using Nextify.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Nextify.Extensions
{
    public static class EntityHelperMethods
    {
        public static IQueryable<TEntity> WhereGeneric<TEntity, TPredicateWellKnownType>(this IQueryable<TEntity> query, Expression<Func<TPredicateWellKnownType, bool>> predicate)
        {
            if (typeof(TEntity).GetInterfaces().Contains(typeof(TPredicateWellKnownType)))
            {
                query = ((IQueryable<TPredicateWellKnownType>)query)
                    .Where(predicate)
                    .Cast<TEntity>();
            }
            return query;
        }

        public static IQueryable<TEntity> WhereAllPropertiesOfSimilarTypeAreEqual<TEntity, TProperty>(this IQueryable<TEntity> query, TProperty value)
        {
            var param = Expression.Parameter(typeof(TEntity));

            var predicate = PredicateBuilder.New<TEntity>(true);

            foreach (var fieldName in GetEntityFieldsToCompareTo<TEntity, TProperty>())
            {
                var predicateToAdd = Expression.Lambda<Func<TEntity, bool>>(
                    Expression.Equal(
                        Expression.PropertyOrField(param, fieldName),
                        Expression.Constant(value)), param);

                predicate = predicate.Or(predicateToAdd);
            }

            return query.Where(predicate);
        }

        // TODO: You'll need to find out what fields are actually ones you would want to compare on.
        //       This might involve stripping out properties marked with [NotMapped] attributes, for
        //       for example.
        private static IEnumerable<string> GetEntityFieldsToCompareTo<TEntity, TProperty>()
        {
            var entityType = typeof(TEntity);
            var propertyType = typeof(TProperty);

            var fields = entityType.GetFields()
                                .Where(f => f.FieldType == propertyType)
                                .Select(f => f.Name);

            var properties = entityType.GetProperties()
                                    .Where(p => p.PropertyType == propertyType)
                                    .Select(p => p.Name);

            return fields.Concat(properties);
        }

        public static IQueryable<TEntity> WhereAllPropertiesContains<TEntity>(this IQueryable<TEntity> query, params string[] values)
            => query.WhereAllPropertiesContains(true, values);

        public static IQueryable<TEntity> WhereAllPropertiesContains<TEntity>(this IQueryable<TEntity> query, bool onlyPgm, params string[] values)
        {
            var param = Expression.Parameter(typeof(TEntity));

            var predicate = PredicateBuilder.New<TEntity>(true);

            var parameterExp = Expression.Parameter(typeof(TEntity), "type");

            var method = typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) });
            var methodUpper = typeof(string).GetMethod(nameof(string.ToUpper), new[] { typeof(string) });
            var to_string_method = typeof(object).GetMethod(nameof(object.ToString));

            foreach (var value in values)
            {
                if (string.IsNullOrEmpty(value))
                    continue;

                if (!value.Contains("&"))
                {
                    foreach (var fieldName in GetEntityProperties<TEntity>(onlyPgm))
                    {

                        var propertyExp = Expression.Property(parameterExp, fieldName);
                        var someValue = Expression.Constant(value, typeof(string));
                        var containsMethodExp = Expression.Call(
                                                              Expression.Call(propertyExp, to_string_method)
                                                              , method, someValue);
                        var predicateToAdd = Expression.Lambda<Func<TEntity, bool>>(containsMethodExp, parameterExp);

                        predicate = predicate.Or(predicateToAdd);
                    }
                }
                else
                {
                    var predicateAnd = PredicateBuilder.New<TEntity>(true);
                    foreach (var item in value.Split('&'))
                    {
                        if (string.IsNullOrEmpty(item))
                            continue;

                        var predicateOr = PredicateBuilder.New<TEntity>(true);
                        foreach (var fieldName in GetEntityProperties<TEntity>(onlyPgm))
                        {

                            var propertyExp = Expression.Property(parameterExp, fieldName);
                            var someValue = Expression.Constant(item, typeof(string));
                            var containsMethodExp = Expression.Call(
                                                                  Expression.Call(propertyExp, to_string_method)
                                                                  , method, someValue);
                            var predicateToAdd = Expression.Lambda<Func<TEntity, bool>>(containsMethodExp, parameterExp);

                            predicateOr = predicateOr.Or(predicateToAdd);
                        }
                        predicateAnd.And(predicateOr);
                    }
                    predicate.Or(predicateAnd);

                }
            }

            return query.AsExpandable().Where(predicate);
        }

        // TODO: You'll need to find out what fields are actually ones you would want to compare on.
        //       This might involve stripping out properties marked with [NotMapped] attributes, for
        //       for example.
        private static IEnumerable<string> GetEntityProperties<TEntity>(bool onlyPgm)
        {
            var entityType = typeof(TEntity);
            var allowedBaseTypes = new List<Type>
                { typeof(int), typeof(decimal), typeof(string), typeof(double), typeof(float), typeof(long), typeof(Guid), typeof(DateTime),
                    typeof(int?), typeof(decimal?), typeof(string), typeof(double?), typeof(float?), typeof(long?), typeof(Guid?), typeof(DateTime?)
                    };

            var properties = entityType.GetPropertyInfosIncludingBaseClasses()
                                    .Where(e => allowedBaseTypes.Contains(e.PropertyType));

            if (onlyPgm)
                properties = properties.Where(e => e.GetCustomAttributes(typeof(LayoutColumn), true).HasElements());

            return properties.Select(p => p.Name);
        }

        public static IQueryable<TModel> TakeIfNotZero<TModel>(this IQueryable<TModel> query, int top) => top > 0 ? query.Take(top) : query;

        public static IQueryable<TModel> WhereIfNotNull<TModel>(this IQueryable<TModel> query, Expression<Func<TModel, bool>> predicate) => predicate == null ? query : query.Where(predicate);


  

    }


 

}
