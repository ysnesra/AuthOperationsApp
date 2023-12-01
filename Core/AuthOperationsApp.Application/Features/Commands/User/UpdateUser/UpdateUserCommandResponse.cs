
using AuthOperationsApp.Application.DTOs.User;

namespace AuthOperationsApp.Application.Features.Commands.User.UpdateUser
{
    public class UpdateUserCommandResponse
    {
        public UpdateUserInfoDto UpdateUserInfoDto { get; set; }
        public UpdateUserCommandResponse(UpdateUserInfoDto updateUserInfoDto)
        {
            UpdateUserInfoDto = updateUserInfoDto;
        }
    }
}
