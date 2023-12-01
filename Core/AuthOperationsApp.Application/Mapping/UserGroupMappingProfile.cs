
using AuthOperationsApp.Application.DTOs.UserGroup;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;


namespace AuthOperationsApp.Application.Mapping
{
    public class UserGroupMappingProfile : Profile
    {
        public UserGroupMappingProfile()
        {
            CreateMap<UserGroup, AssignUserToGroupDto>();
            CreateMap<UserGroup, UnassignUserToGroupDto>();
        }
    }
}
