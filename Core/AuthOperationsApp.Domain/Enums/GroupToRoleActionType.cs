using System.ComponentModel;


namespace AuthOperationsApp.Domain.Enums
{
    public enum GroupToRoleActionType
    {
        [Description("GroupAdd")] GroupAdd,
        [Description("GroupDelete")] GroupDelete,
    }
}
