

using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole
{
    public class GetAllGroupByUserQueryResponse
    {
        public GroupByRoleInfoDto GroupByRoleInfoDto { get; set; }
        public GetAllGroupByUserQueryResponse(GroupByRoleInfoDto groupByRoleInfoDto)
        {
            GroupByRoleInfoDto = groupByRoleInfoDto;
        }
    }
}
