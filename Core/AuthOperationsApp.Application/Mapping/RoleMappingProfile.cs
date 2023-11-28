

using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;

namespace AuthOperationsApp.Application.Mapping
{
    public class RoleMappingProfile : Profile
    {
        public RoleMappingProfile()
        {
            CreateMap<Role, RoleListDto>();
           
        }
    }
}
