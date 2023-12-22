

namespace AuthOperationsApp.Application.Model.RoleGroup
{
    public class AllGroupsByRoleModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } //GroupName
        public bool IsRole { get; set; } = false; //true ise Rolün olduğu Gruplar - false Rolü olmayan Gruplar
    }
}
