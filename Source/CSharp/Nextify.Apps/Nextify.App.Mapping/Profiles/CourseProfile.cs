using AutoMapper;
using Nextify.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nextify.Mapping.Profiles
{
   public class CourseProfile : Profile
    {

      public  CourseProfile()
        {
            CreateMap<Course, CourseDTO>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(e => e.Author.Name))
                ;
            
        }
    }
}
