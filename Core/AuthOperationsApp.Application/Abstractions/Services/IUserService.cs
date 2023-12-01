
using AuthOperationsApp.Application.DTOs.User;
using AuthOperationsApp.Application.Features.Commands.User.UpdateUser;


namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<List<UserListDto?>> GetAllUserAsync();
        Task<UserByIdDto> GetUserByIdAsync(Guid id, bool tracking = true);
        Task<UpdateUserInfoDto> UpdateAsync(UpdateUserCommandRequest request,
          CancellationToken cancellationToken, bool tracking = false);
    }
}
