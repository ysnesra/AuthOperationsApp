using AuthOperationsApp.Application.DTOs.Group;
using AuthOperationsApp.Application.DTOs.RoleGroup;
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

        }
       
    }
}
