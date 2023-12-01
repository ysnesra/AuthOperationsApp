
using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.User
{
    public class UserListInfoDto : BaseDto
    {
        public List<UserListDto> UserListDto { get; set; }
    }
}
