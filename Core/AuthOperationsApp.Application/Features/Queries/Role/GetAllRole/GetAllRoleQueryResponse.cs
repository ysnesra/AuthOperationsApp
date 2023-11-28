

using AuthOperationsApp.Application.DTOs.Role;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRole
{
    public class GetAllRoleQueryResponse
    {
        public RoleListInfoDto RoleListInfoDtos { get; set; }
        public GetAllRoleQueryResponse(RoleListInfoDto roleListInfoDtos)
        {
            RoleListInfoDtos = roleListInfoDtos;
        }
    }
}
