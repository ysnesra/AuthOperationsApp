using AuthOperationsApp.Application.DTOs.Role;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetRoleById
{
    public class GetRoleByIdQueryResponse
    {
        public RoleByIdInfoDto RoleByIdInfoDto { get; set; }
        public GetRoleByIdQueryResponse(RoleByIdInfoDto roleByIdInfoDto)
        {
            RoleByIdInfoDto = roleByIdInfoDto;
        }
    }
}
