
using AuthOperationsApp.Application.DTOs.UserGroup;

namespace AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupByUser
{
    public class GetAllGroupByUserQueryResponse
    {
        public GroupByUserInfoDto GroupByUserInfoDto { get; set; }
        public GetAllGroupByUserQueryResponse(GroupByUserInfoDto groupByUserInfoDto)
        {
            GroupByUserInfoDto = groupByUserInfoDto;
        }
    }
}
