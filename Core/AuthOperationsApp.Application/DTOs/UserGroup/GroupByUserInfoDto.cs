
using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.UserGroup
{
    public class GroupByUserInfoDto : BaseDto
    {
        public List<GroupByUserDto> GroupByUserDto { get; set; }
    }
}
