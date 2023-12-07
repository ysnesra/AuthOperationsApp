
using AuthOperationsApp.Application.DTOs.UserGroup;


namespace AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupNoUser
{
    public class GetAllGroupNoUserQueryResponse
    {
        public AllGroupNoUserInfoDto AllGroupNoUserInfoDto { get; set; }
        public GetAllGroupNoUserQueryResponse(AllGroupNoUserInfoDto allGroupNoUserInfoDto)
        {
            AllGroupNoUserInfoDto = allGroupNoUserInfoDto;
        }
    }
}
