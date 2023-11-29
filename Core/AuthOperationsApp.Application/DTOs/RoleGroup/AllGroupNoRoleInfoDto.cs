using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class AllGroupNoRoleInfoDto : BaseDto
    {
        public List<AllGroupNoRoleDto> AllGroupNoRoleDto { get; set; }
    }
}
