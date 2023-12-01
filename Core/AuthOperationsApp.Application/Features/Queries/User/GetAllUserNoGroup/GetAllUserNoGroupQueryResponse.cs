
using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUserNoGroup
{
    public class GetAllUserNoGroupQueryResponse
    {
        public AllUserNoGroupInfoDto AllUserNoGroupInfoDto { get; set; }
        public GetAllUserNoGroupQueryResponse(AllUserNoGroupInfoDto allUserNoGroupInfoDto)
        {
            AllUserNoGroupInfoDto = allUserNoGroupInfoDto;
        }
    }
}
