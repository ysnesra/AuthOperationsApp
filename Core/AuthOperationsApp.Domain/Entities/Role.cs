using AuthOperationsApp.Domain.Entities.Common;

namespace AuthOperationsApp.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }


        public virtual IList<Group> Groups { get; set; }

    }
}
