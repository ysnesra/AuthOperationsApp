
using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUserByGroup
{
    public class GetAllUserByGroupQueryResponse
    {
        public UserByGroupInfoDto UserByGroupInfoDto { get; set; }
        public GetAllUserByGroupQueryResponse(UserByGroupInfoDto userByGroupInfoDto)
        {
            UserByGroupInfoDto = userByGroupInfoDto;
        }
    }
}
