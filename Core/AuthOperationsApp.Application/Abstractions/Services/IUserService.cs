

using AuthOperationsApp.Application.DTOs.User;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<List<UserListDto?>> GetAllUserAsync();
    }
}
