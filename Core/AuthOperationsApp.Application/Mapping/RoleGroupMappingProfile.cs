using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;


namespace AuthOperationsApp.Application.Mapping
{
    public class RoleGroupMappingProfile : Profile
    {
        public RoleGroupMappingProfile()
        {
            CreateMap<RoleGroup, AssignGroupToRoleDto>(); 
            CreateMap<RoleGroup, UnassignGroupToRoleDto>(); 

            CreateMap<RoleGroup, AssignRoleToGroupDto>();
            CreateMap<RoleGroup, UnassignRoleToGroupDto>();

        }
    }
}
