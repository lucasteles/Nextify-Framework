using System;

namespace Pragma.Mapping
{
    public interface IMapper
    {
        //
        // Summary:
        //     Execute a mapping from the source object to a new destination object with explicit
        //     System.Type objects
        //
        // Parameters:
        //   source:
        //     Source object to map from
        //
        //   sourceType:
        //     Source type to use
        //
        //   destinationType:
        //     Destination type to create
        //
        // Returns:
        //     Mapped destination object
        object Map(object source, Type sourceType, Type destinationType);

        //
        // Summary:
        //     Execute a mapping from the source object to existing destination object with
        //     explicit System.Type objects
        //
        // Parameters:
        //   source:
        //     Source object to map from
        //
        //   destination:
        //     Destination object to map into
        //
        //   sourceType:
        //     Source type to use
        //
        //   destinationType:
        //     Destination type to use
        //
        // Returns:
        //     Mapped destination object, same instance as the destination object
        object Map(object source, object destination, Type sourceType, Type destinationType);

        //
        // Summary:
        //     Execute a mapping from the source object to a new destination object. The source
        //     type is inferred from the source object.
        //
        // Parameters:
        //   source:
        //     Source object to map from
        //
        // Type parameters:
        //   TDestination:
        //     Destination type to create
        //
        // Returns:
        //     Mapped destination object
        TDestination Map<TDestination>(object source);

        //
        // Summary:
        //     Execute a mapping from the source object to a new destination object.
        //
        // Parameters:
        //   source:
        //     Source object to map from
        //
        // Type parameters:
        //   TSource:
        //     Source type to use, regardless of the runtime type
        //
        //   TDestination:
        //     Destination type to create
        //
        // Returns:
        //     Mapped destination object
        TDestination Map<TSource, TDestination>(TSource source);


        //
        // Summary:
        //     Execute a mapping from the source object to the existing destination object.
        //
        // Parameters:
        //   source:
        //     Source object to map from
        //
        //   destination:
        //     Destination object to map into
        //
        // Type parameters:
        //   TSource:
        //     Source type to use
        //
        //   TDestination:
        //     Dsetination type
        //
        // Returns:
        //     The mapped destination object, same instance as the destination object
        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
    }
}
