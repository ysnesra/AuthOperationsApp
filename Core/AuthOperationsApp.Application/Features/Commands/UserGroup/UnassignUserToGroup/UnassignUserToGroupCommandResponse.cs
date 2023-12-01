using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignUserToGroup
{
    public class UnassignUserToGroupCommandResponse
    {
        public UnassignUserToGroupInfoDto UnassignUserToGroupInfoDto { get; set; }

        public UnassignUserToGroupCommandResponse(UnassignUserToGroupInfoDto unassignUserToGroupInfoDto)
        {
            UnassignUserToGroupInfoDto = unassignUserToGroupInfoDto;

        }
    }
}
