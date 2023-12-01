

namespace AuthOperationsApp.Application.DTOs.UserGroup
{
    public class UnassignUserToGroupDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
    }
}
