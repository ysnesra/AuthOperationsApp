using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.Features.Commands.Role.UpdateRole;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IRoleService
    {
        Task<List<RoleListDto?>> GetAllRoleAsync();
        Task<RoleByIdInfoDto> GetRoleByIdAsync(Guid id, bool tracking = true);
        Task<UpdateRoleInfoDto> UpdateAsync(UpdateRoleCommandRequest request,
          CancellationToken cancellationToken, bool tracking = false);
    }
}
