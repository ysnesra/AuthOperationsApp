using AuthOperationsApp.Domain.Entities.Common;


namespace AuthOperationsApp.Domain.Entities
{
    public class RoleGroup : BaseEntity
    {
        public Guid RoleId { get; set; }


        public Guid GroupId { get; set; }
    }
}
