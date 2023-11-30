

namespace AuthOperationsApp.Application.Constants
{
    public static class Messages
    {
        public static string RolesListed = "Role listed succesfully.";
        public static string RolesListedFailed = "Role list not found.";

        public static string GroupListed = "Group listed succesfully.";
        public static string GroupListedFailed = "Group list not found.";
        
        public static string GroupIdNotExist = "Group with ID {groupId} does not exist in the system.";
        public static string RoleExistInGroup = "Role has already been assigned to Group with ID {groupId}.";
        public static string AssignGroupSuccess = "Group assigned to role successfully."; 

        public static string GroupExistInRole = "Group has already been assigned to Role with ID {roleId}.";
        public static string AssignRoleSuccess = "Role assigned to group successfully."; 

        public static string RoleNotExistInGroup = "Role doesn't exist in Group with ID {groupId}.";
        public static string UnassignGroupSuccess = "Group unassigned to role successfully."; 

        public static string GroupNotExistInRole = "Group doesn't exist in Role with ID {roleId}.";
        public static string UnassignRoleSuccess = "Role unassigned to group successfully.";

        public static string UpdateRoleFailed = $"Failed to update role.";
        public static string RoleNotExist = $"Role doesn't exist.";
        public static string UpdateGroupFailed = $"Failed to update role.";
        public static string GroupNotExist = $"Role doesn't exist.";

        public static string GroupsBelongingRoleNotFound = "Groups belongig role not found.";
        public static string GroupsBelongingRoleSuccess = "Groups belongig rolelisted succesfully.";

        public static string GroupsWithoutAssignRolesNotFound = "Groups without assigned roles not found.";
        public static string GroupsWithoutAssignRolesSuccess = "Groups without assigned roles listed succesfully.";
      

    }
}
