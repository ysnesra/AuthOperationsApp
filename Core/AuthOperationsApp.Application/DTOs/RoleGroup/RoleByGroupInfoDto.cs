using AuthOperationsApp.Application.DTOs.Common;

namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class RoleByGroupInfoDto : BaseDto
    {
        public List<RoleByGroupDto> RoleByGroupDto { get; set; }
    }
}
