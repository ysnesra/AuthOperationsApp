
using AuthOperationsApp.Application.DTOs.User;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;

namespace AuthOperationsApp.Application.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserByGroupDto>(); 

            CreateMap<User, AllUserNoGroupDto>();
            
            CreateMap<User, UserListDto>();

            CreateMap<User, UpdateUserInfoDto>();
            CreateMap<User, UserByIdDto>().ReverseMap();

        }
           
    }
}
