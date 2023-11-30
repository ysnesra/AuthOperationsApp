using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class AllRoleNoGroupInfoDto : BaseDto
    {
        public List<AllRoleNoGroupDto> AllRoleNoGroupDto { get; set; }
    }
}
