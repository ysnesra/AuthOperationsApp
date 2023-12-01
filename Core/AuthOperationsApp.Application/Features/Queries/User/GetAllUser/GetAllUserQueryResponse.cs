
using AuthOperationsApp.Application.DTOs.User;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUser
{
    public class GetAllUserQueryResponse
    {
        public UserListInfoDto UserListInfoDto { get; set; }
        public GetAllUserQueryResponse(UserListInfoDto userListInfoDto)
        {
            UserListInfoDto = userListInfoDto;
        }
    }
}
