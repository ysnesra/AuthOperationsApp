using AuthOperationsApp.Domain.Entities.Common;

namespace AuthOperationsApp.Domain.Entities
{
    public class UserGroup : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
    }
}
