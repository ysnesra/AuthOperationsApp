

namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class AssignRoleToGroupDto
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid GroupId { get; set; }
    }
}
