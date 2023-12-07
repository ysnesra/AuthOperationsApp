using AuthOperationsApp.Application.DTOs.Group;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;


namespace AuthOperationsApp.Application.Mapping
{
    public class GroupMappingProfile : Profile
    {
        public GroupMappingProfile()
        {
            CreateMap<Group, GroupByRoleDto>();
            CreateMap<Group, AllGroupNoRoleDto>();
            CreateMap<Group, GroupListDto>();

            CreateMap<Group, GroupByIdDto>().ReverseMap();
            CreateMap<Group, UpdateGroupInfoDto>();
            CreateMap<Group, AllRoleNoGroupDto>();

            CreateMap<Group, GroupByUserDto>();
            CreateMap<Group, AllGroupNoUserDto>();
            
        }
    }
}
