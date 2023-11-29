using AuthOperationsApp.Application.DTOs.RoleGroup;


namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignGroupToRole
{
    public class AssignGroupToRoleCommandResponse
    {
        public AssignGroupToRoleInfoDto AssignGroupToRoleInfoDto { get; set; }

        public AssignGroupToRoleCommandResponse(AssignGroupToRoleInfoDto assignGroupToRoleInfoDto)
        {
            AssignGroupToRoleInfoDto = assignGroupToRoleInfoDto;

        }
    }
}
