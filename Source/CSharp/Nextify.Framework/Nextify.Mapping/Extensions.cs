using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Nextify.Mapping
{
    public static class Extensions
    {

        private static IConfigurationProvider GetConfig()
        {

            var config = new MapperConfiguration(cfg => ProfileRegister.Profiles.ToList().ForEach(e => cfg.AddProfiles(e)));

            return config;

        }

        //
        // Summary:
        //     Extension method to project from a queryable using the provided mapping engine
        //
        // Parameters:
        //   source:
        //     Queryable source
        //
        //   membersToExpand:
        //     Explicit members to expand
        //
        // Type parameters:
        //   TDestination:
        //     Destination type
        //
        // Returns:
        //     Expression to project into
        //
        // Remarks:
        //     Projections are only calculated once and cached
        public static IQueryable<TDestination> MapTo<TDestination>(this IQueryable source, params Expression<Func<TDestination, object>>[] membersToExpand)
        {
            return source.ProjectTo(GetConfig(), membersToExpand);
        }

        //
        // Summary:
        //     Extension method to project from a queryable using the provided mapping engine
        //
        // Parameters:
        //   source:
        //     Queryable source
        //
        //   parameters:
        //     Optional parameter object for parameterized mapping expressions
        //
        //   membersToExpand:
        //     Explicit members to expand
        //
        // Type parameters:
        //   TDestination:
        //     Destination type
        //
        // Returns:
        //     Expression to project into
        //
        // Remarks:
        //     Projections are only calculated once and cached

        public static IQueryable<TDestination> MapTo<TDestination>(this IQueryable source, object parameters, params Expression<Func<TDestination, object>>[] membersToExpand)
        {
            return source.ProjectTo(GetConfig(), parameters, membersToExpand);
        }

        //
        // Summary:
        //     Projects the source type to the destination type given the mapping configuration
        //
        // Parameters:
        //   source:
        //     Queryable source
        //
        //   parameters:
        //     Optional parameter object for parameterized mapping expressions
        //
        //   membersToExpand:
        //     Explicit members to expand
        //
        // Type parameters:
        //   TDestination:
        //     Destination type to map to
        //
        // Returns:
        //     Queryable result, use queryable extension methods to project and execute result
        public static IQueryable<TDestination> MapTo<TDestination>(this IQueryable source, IDictionary<string, object> parameters, params string[] membersToExpand)
        {
            return source.ProjectTo<TDestination>(GetConfig(), parameters, membersToExpand);
        }

    }
}
