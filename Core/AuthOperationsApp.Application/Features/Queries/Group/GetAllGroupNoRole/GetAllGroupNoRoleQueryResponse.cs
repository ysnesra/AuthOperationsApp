
using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupNoRole
{
    public class GetAllGroupNoRoleQueryResponse
    {
        public AllGroupNoRoleInfoDto AllGroupNoRoleInfoDto { get; set; }
        public GetAllGroupNoRoleQueryResponse(AllGroupNoRoleInfoDto allGroupNoRoleInfoDto)
        {
            AllGroupNoRoleInfoDto = allGroupNoRoleInfoDto;
        }
    }
}
