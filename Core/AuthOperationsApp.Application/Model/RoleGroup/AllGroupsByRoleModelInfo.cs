using AuthOperationsApp.Application.DTOs.Common;


namespace AuthOperationsApp.Application.Model.RoleGroup
{
    public class AllGroupsByRoleModelInfo : BaseDto
    {
        public List<AllGroupsByRoleModel> AllGroupsByRoleModel { get; set; }
    }
}
