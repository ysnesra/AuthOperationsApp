using AuthOperationsApp.Application.DTOs.RoleGroup;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleNoGroup
{
    public class GetAllRoleNoGroupQueryResponse
    {
        public AllRoleNoGroupInfoDto AllRoleNoGroupInfoDto { get; set; }
        public GetAllRoleNoGroupQueryResponse(AllRoleNoGroupInfoDto allRoleNoGroupInfoDto)
        {
            AllRoleNoGroupInfoDto = allRoleNoGroupInfoDto;
        }
    }
}
