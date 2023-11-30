using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleByGroup
{
    public class GetAllRoleByGroupQueryResponse
    {
        public RoleByGroupInfoDto RoleByGroupInfoDto { get; set; }
        public GetAllRoleByGroupQueryResponse(RoleByGroupInfoDto roleByGroupInfoDto)
        {
            RoleByGroupInfoDto = roleByGroupInfoDto;
        }
    }
}
