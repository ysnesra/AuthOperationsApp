using AuthOperationsApp.Application.DTOs.Group;

namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroup
{
    public class GetAllGroupQueryResponse
    {
        public GroupListInfoDto GroupListInfoDto { get; set; }
        public GetAllGroupQueryResponse(GroupListInfoDto groupListInfoDto)
        {
            GroupListInfoDto = groupListInfoDto;
        }
    }
}
