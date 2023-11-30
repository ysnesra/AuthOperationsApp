using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IRoleGroupService
    {
        Task<List<GroupByRoleDto?>> GetGroupsByRoleIdAsync(Guid roleId, bool tracking = false);
        Task<List<AllGroupNoRoleDto?>> GetGroupsNoRoleAsync(Guid roleId);
        Task<AssignGroupToRoleInfoDto> AssignGroupToRoleAsync(Guid groupId, Guid roleId);
        Task<UnassignGroupToRoleInfoDto> UnassignGroupToRoleAsync(Guid groupId, Guid roleId);
        Task<List<RoleByGroupDto?>> GetRolesByGroupIdAsync(Guid groupId, bool tracking = false);
        Task<List<AllRoleNoGroupDto?>> GetRolesNoGroupAsync(Guid groupId);
        Task<AssignRoleToGroupInfoDto> AssignRoleToGroupAsync(Guid groupId, Guid roleId);
        Task<UnassignRoleToGroupInfoDto> UnassignRoleToGroupAsync(Guid groupId, Guid roleId);
    }
}
