using AutoMapper;
using Nextify.Mapping;
using System;
using System.Linq;

namespace Nextify.Mapping.Core
{

    public class Mapper : IMapper
    {
        protected MapperConfiguration Config;

        public Mapper()
        {

            Config = new MapperConfiguration(e => ProfileRegister.Profiles.ToList().ForEach(c => e.AddProfiles(c)));
        }

        private AutoMapper.IMapper _mapper
        {
            get
            {
                return Config.CreateMapper();
            }
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            return _mapper.Map(source, sourceType, destinationType);
        }

        public object Map(object source, object destination, Type sourceType, Type destinationType)
        {
            return _mapper.Map(source, destination, sourceType, destinationType);
        }

        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return _mapper.Map(source, destination);
        }
    }
}
