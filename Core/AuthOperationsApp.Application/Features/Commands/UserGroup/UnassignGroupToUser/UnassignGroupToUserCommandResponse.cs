
using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignGroupToUser
{
    public class UnassignGroupToUserCommandResponse
    {
        public UnassignGroupToUserInfoDto UnassignGroupToUserInfoDto { get; set; }

        public UnassignGroupToUserCommandResponse(UnassignGroupToUserInfoDto unassignGroupToUserInfoDto)
        {
            UnassignGroupToUserInfoDto = unassignGroupToUserInfoDto;

        }
    }
}
