using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IRoleGroupService
    {
        Task<List<GroupByRoleDto?>> GetGroupsByRoleIdAsync(Guid roleId, bool tracking = false);
        Task<List<AllGroupNoRoleDto?>> GetGroupsNoRoleAsync(Guid roleId);
    }
}
