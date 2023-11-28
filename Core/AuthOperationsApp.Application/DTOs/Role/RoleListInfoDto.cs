using AuthOperationsApp.Application.DTOs.Common;

namespace AuthOperationsApp.Application.DTOs.Role
{
    public class RoleListInfoDto :BaseDto
    {
        public List<RoleListDto> RoleListDto { get; set; }
    }
}
