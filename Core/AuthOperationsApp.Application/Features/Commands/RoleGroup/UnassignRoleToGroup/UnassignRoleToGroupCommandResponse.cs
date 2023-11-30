
using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignRoleToGroup
{
    public class UnassignRoleToGroupCommandResponse
    {
        public UnassignRoleToGroupInfoDto UnassignRoleToGroupInfoDto { get; set; }

        public UnassignRoleToGroupCommandResponse(UnassignRoleToGroupInfoDto unassignRoleToGroupInfoDto)
        {
            UnassignRoleToGroupInfoDto = unassignRoleToGroupInfoDto;

        }
    }
}
