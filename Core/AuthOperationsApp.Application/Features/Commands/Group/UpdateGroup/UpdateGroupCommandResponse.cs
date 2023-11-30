using AuthOperationsApp.Application.DTOs.Group;


namespace AuthOperationsApp.Application.Features.Commands.Group.UpdateGroup
{
    public class UpdateGroupCommandResponse
    {
        public UpdateGroupInfoDto UpdateGroupInfoDto { get; set; }
        public UpdateGroupCommandResponse(UpdateGroupInfoDto updateGroupInfoDto)
        {
            UpdateGroupInfoDto = updateGroupInfoDto;
        }
    }
}
