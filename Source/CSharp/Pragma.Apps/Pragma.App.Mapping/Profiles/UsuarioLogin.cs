using AutoMapper;
using Pragma.App.Model;
using Pragma.App.Models.DTO;
using System.Linq;

namespace Pragma.App.Mapping.Profiles
{
    public class UsuarioLogin : Profile
    {
        public UsuarioLogin()
        {
            CreateMap<DbUsuarioLogin, UserDTO>()
                .ForMember(e => e.Grupos, e => e.MapFrom(i => i.ListGrups.Count().ToString()));
        }
    }
}
