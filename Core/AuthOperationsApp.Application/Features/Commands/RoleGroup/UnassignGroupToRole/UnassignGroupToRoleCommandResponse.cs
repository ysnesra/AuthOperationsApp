using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignGroupToRole
{
    public class UnassignGroupToRoleCommandResponse
    {
        public UnassignGroupToRoleInfoDto UnassignGroupToRoleInfoDto { get; set; }

        public UnassignGroupToRoleCommandResponse(UnassignGroupToRoleInfoDto unassignGroupToRoleInfoDto)
        {
            UnassignGroupToRoleInfoDto = unassignGroupToRoleInfoDto;

        }
    }
}
