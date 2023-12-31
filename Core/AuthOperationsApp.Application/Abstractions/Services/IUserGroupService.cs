﻿
using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IUserGroupService
    {
        Task<List<UserByGroupDto?>> GetUsersByGroupIdAsync(Guid groupId, bool tracking = false);
        Task<List<AllUserNoGroupDto?>> GetUserNoGroupAsync(Guid groupId);
        Task<AssignUserToGroupInfoDto> AssignUserToGroupAsync(Guid groupId, Guid userId);
        Task<UnassignUserToGroupInfoDto> UnassignUserToGroupAsync(Guid groupId, Guid userId);
        Task<List<GroupByUserDto>> GetGroupsByUserIdAsync(Guid userId, bool tracking = false);
        Task<List<AllGroupNoUserDto>> GetGroupsNoUserAsync(Guid userId);
        Task<AssignGroupToUserInfoDto> AssignGroupToUserAsync(Guid groupId, Guid userId);
        Task<UnassignGroupToUserInfoDto> UnassignGroupToUserAsync(Guid groupId, Guid userId);
    }
}
