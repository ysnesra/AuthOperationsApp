using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.UserGroup
{
    public class AllGroupNoUserInfoDto : BaseDto
    {
        public List<AllGroupNoUserDto> AllGroupNoUserDto { get; set; }
    }
}
