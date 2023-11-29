using AuthOperationsApp.Application.DTOs.Role;

namespace AuthOperationsApp.Application.Features.Commands.Role.UpdateRole
{
    public class UpdateRoleCommandResponse
    {
        public UpdateRoleInfoDto UpdateRoleInfoDto { get; set; }
        public UpdateRoleCommandResponse(UpdateRoleInfoDto updateRoleInfoDto)
        {
            UpdateRoleInfoDto = updateRoleInfoDto;
        }
    }
}
