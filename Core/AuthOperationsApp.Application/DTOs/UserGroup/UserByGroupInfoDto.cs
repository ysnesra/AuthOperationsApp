using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.UserGroup
{
    public class UserByGroupInfoDto : BaseDto
    {
        public List<UserByGroupDto> UserByGroupDto { get; set; }
    }
}
