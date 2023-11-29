

namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class UnassignGroupToRoleDto
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid GroupId { get; set; }
    }
}
