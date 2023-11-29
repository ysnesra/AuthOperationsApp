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
            CreateMap<Role, RoleByIdInfoDto>().ReverseMap();

            CreateMap<RoleByIdInfoDto, UpdateRoleInfoDto>();
            CreateMap<UpdateRoleDto, Role>();
            CreateMap<Role, UpdateRoleInfoDto>();


        }
    }
}
