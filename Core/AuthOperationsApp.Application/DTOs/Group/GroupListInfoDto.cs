using AuthOperationsApp.Application.DTOs.Common;
using AuthOperationsApp.Application.DTOs.Role;

namespace AuthOperationsApp.Application.DTOs.Group
{
    public class GroupListInfoDto : BaseDto
    {
        public List<GroupListDto> GroupListDto { get; set; }
    }
}
