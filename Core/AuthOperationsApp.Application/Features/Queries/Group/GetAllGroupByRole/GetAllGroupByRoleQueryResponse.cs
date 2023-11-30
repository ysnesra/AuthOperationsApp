

using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole
{
    public class GetAllGroupByRoleQueryResponse
    {
        public GroupByRoleInfoDto GroupByRoleInfoDto { get; set; }
        public GetAllGroupByRoleQueryResponse(GroupByRoleInfoDto groupByRoleInfoDto)
        {
            GroupByRoleInfoDto = groupByRoleInfoDto;
        }
    }
}
