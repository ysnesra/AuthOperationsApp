
using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.AssignUserToGroup
{
    public class AssignUserToGroupCommandResponse
    {
        public AssignUserToGroupInfoDto AssignUserToGroupInfoDto { get; set; }

        public AssignUserToGroupCommandResponse(AssignUserToGroupInfoDto assignUserToGroupInfoDto)
        {
            AssignUserToGroupInfoDto = assignUserToGroupInfoDto;

        }
    }
}
