
using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignRoleToGroup
{
    public class AssignRoleToGroupCommandResponse
    {
        public AssignRoleToGroupInfoDto AssignRoleToGroupInfoDto { get; set; }

        public AssignRoleToGroupCommandResponse(AssignRoleToGroupInfoDto assignRoleToGroupInfoDto)
        {
            AssignRoleToGroupInfoDto = assignRoleToGroupInfoDto;

        }
    }
}
