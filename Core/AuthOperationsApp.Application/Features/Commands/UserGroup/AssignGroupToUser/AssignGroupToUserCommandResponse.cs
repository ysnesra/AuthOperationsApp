

using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.AssignGroupToUser
{
    public class AssignGroupToUserCommandResponse
    {
        public AssignGroupToUserInfoDto AssignGroupToUserInfoDto { get; set; }

        public AssignGroupToUserCommandResponse(AssignGroupToUserInfoDto assignGroupToUserInfoDto)
        {
            AssignGroupToUserInfoDto = assignGroupToUserInfoDto;

        }
    }
}
