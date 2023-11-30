using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;

namespace AuthOperationsApp.Application.Mapping
{
    public class RoleMappingProfile : Profile
    {
        public RoleMappingProfile()
        {
            CreateMap<Role, RoleListDto>();
            CreateMap<Role, RoleByIdDto>().ReverseMap();

            CreateMap<RoleByIdDto, UpdateRoleInfoDto>();

            CreateMap<UpdateRoleInfoDto, RoleByIdDto>();
            CreateMap<UpdateRoleDto, Role>();
            CreateMap<Role, UpdateRoleInfoDto>();

            CreateMap<Role, RoleByIdDto>();

            CreateMap<Role, RoleByGroupDto>(); 
            CreateMap<Role, AllRoleNoGroupDto>(); 
        }
    }
}
