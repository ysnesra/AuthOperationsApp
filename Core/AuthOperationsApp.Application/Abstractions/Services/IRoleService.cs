using AuthOperationsApp.Application.DTOs.Role;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IRoleService
    {
        Task<List<RoleListDto?>> GetAllRoleAsync();
    }
}
