using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class GroupByRoleInfoDto : BaseDto
    {
        public List<GroupByRoleDto> GroupByRoleDto { get; set; }
    }
}
