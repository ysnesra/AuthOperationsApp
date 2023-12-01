
using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.DTOs.UserGroup
{
    public class AllUserNoGroupInfoDto : BaseDto
    {
        public List<AllUserNoGroupDto> AllUserNoGroupDto { get; set; }
    }
}
