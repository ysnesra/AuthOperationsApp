using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuthOperationsApp.Persistence.Services
{
    public class UserGroupService : IUserGroupService
    {
        private readonly IMapper _mapper;
        private readonly IUserGroupReadRepository _userGroupReadRepository;
        private readonly IUserGroupWriteRepository _userGroupWriteRepository;
        private readonly IUserReadRepository _userReadRepository;

        public UserGroupService(IMapper mapper, IUserGroupReadRepository userGroupReadRepository, IUserGroupWriteRepository userGroupWriteRepository, IUserReadRepository userReadRepository)
        {
            _mapper = mapper;
            _userGroupReadRepository = userGroupReadRepository;
            _userGroupWriteRepository = userGroupWriteRepository;
            _userReadRepository = userReadRepository;
        }

        public async Task<List<UserByGroupDto?>> GetUsersByGroupIdAsync(Guid groupId, bool tracking = false)
        {
            var userIds = await _userGroupReadRepository.GetWhere(x => x.GroupId == groupId).Select(x => x.UserId).ToListAsync();

            var userInfos = await _userReadRepository.GetWhere(r => userIds.Contains(r.Id), tracking).ToListAsync();

            var usersDto = _mapper.Map<List<UserByGroupDto>>(userInfos);
            return usersDto;
        }


        //Grupta olmayan kullanıcıları Getirme   
        public async Task<List<AllUserNoGroupDto?>> GetUserNoGroupAsync(Guid groupId)
        {
            var usersInGroup = await _userGroupReadRepository.GetWhere(x => x.GroupId == groupId).ToListAsync();
            var usersInGroupIds = usersInGroup.Select(rg => rg.UserId).ToList();

            var usersNotInGroup = await _userReadRepository.GetWhere(user => !usersInGroupIds.Contains(user.Id)).ToListAsync();

            var usersDto = _mapper.Map<List<AllUserNoGroupDto>>(usersNotInGroup);
            return usersDto;
        }

        //Gruba Kullanıcı atama
        public async Task<AssignUserToGroupInfoDto> AssignUserToGroupAsync(Guid groupId, Guid userId)
        {
            var existingUser = await _userReadRepository.GetByIdAsync(userId);

            if (existingUser is null)
            {
                return new AssignUserToGroupInfoDto
                {
                    Success = false,
                    Message = Messages.GroupIdNotExist,//UserIdNotExist
                };
            }

            var isUserGroupAssigned = await _userGroupReadRepository.GetWhere(x => x.GroupId == groupId && x.UserId == userId).AnyAsync();
            if (isUserGroupAssigned)
            {
                return new AssignUserToGroupInfoDto
                {
                    Success = false,
                    Message = Messages.GroupExistInRole,//UserExistInRole
                };
            }

            var userGroup = new UserGroup
            {
                Id = Guid.NewGuid(),
                GroupId = groupId,
                UserId = userId
            };

            await _userGroupWriteRepository.AddAsync(userGroup);

            var mappedUserGroup = _mapper.Map<AssignUserToGroupDto>(userGroup);

            return new AssignUserToGroupInfoDto
            {
                Success = true,
                Message = Messages.AssignUserSuccess,
                AssignUserToGroupDto = mappedUserGroup
            };
        }

        //Gruptan Kullanıcı kaldırma 
        public async Task<UnassignUserToGroupInfoDto> UnassignUserToGroupAsync(Guid groupId, Guid userId)
        {
            var isUserGroupAssigned = await _userGroupReadRepository.GetWhere(x => x.GroupId == groupId && x.UserId == userId).FirstOrDefaultAsync();
            if (isUserGroupAssigned is null)
            {
                return new UnassignUserToGroupInfoDto
                {
                    Success = false,
                    Message = Messages.GroupNotExistInUser,
                };
            }

            await _userGroupWriteRepository.RemoveAsync(isUserGroupAssigned.Id);

            var mappedUserGroup = _mapper.Map<UnassignUserToGroupDto>(isUserGroupAssigned);

            return new UnassignUserToGroupInfoDto
            {
                Success = true,
                Message = Messages.UnassignUserSuccess,
                UnassignUserToGroupDto = mappedUserGroup
            };
        }
    }
}
