using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class UnassignGroupToRoleInfoDto : BaseDto
    {
        public UnassignGroupToRoleDto UnassignGroupToRoleDto { get; set; }
    }
}
