

namespace AuthOperationsApp.Application.Constants
{
    public static class Messages
    {
        public static string RolesListed = "Role listed succesfully.";
        public static string RolesListedFailed = "Role list not found.";

        public static string GroupListed = "Group listed succesfully.";
        public static string GroupListedFailed = "Group list not found.";

        public static string UserListed = "User listed succesfully.";
        public static string UserListedFailed = "User list not found.";

        public static string GroupIdNotExist = "Group with ID {groupId} does not exist in the system.";
        public static string RoleExistInGroup = "Role has already been assigned to Group with ID {groupId}.";
        public static string UserExistInGroup = "User has already been assigned to Group with ID {groupId}.";
        public static string AssignGroupSuccess = "Group assigned to role successfully."; 

        public static string GroupExistInRole = "Group has already been assigned to Role with ID {roleId}.";
        public static string AssignRoleSuccess = "Role assigned to group successfully.";

        public static string GroupExistInUser = "Group has already been assigned to User with ID {userId}.";
        public static string AssignUserSuccess = "User assigned to group successfully.";

        public static string RoleNotExistInGroup = "Role doesn't exist in Group with ID {groupId}."; 
        public static string UserNotExistInGroup = "User doesn't exist in Group with ID {groupId}."; 
        public static string UnassignGroupSuccess = "Group unassigned to role successfully."; 

        public static string GroupNotExistInRole = "Group doesn't exist in Role with ID {roleId}.";
        public static string UnassignRoleSuccess = "Role unassigned to group successfully.";

        public static string GroupNotExistInUser = "Group doesn't exist in User with ID {userId}.";
        public static string UnassignUserSuccess = "User unassigned to group successfully.";

        public static string UpdateRoleFailed = $"Failed to update role.";
        public static string RoleNotExist = $"Role doesn't exist.";
        public static string UpdateGroupFailed = $"Failed to update role.";
        public static string GroupNotExist = $"Role doesn't exist.";
        public static string UpdateUserFailed = $"Failed to update user."; 
        public static string UpdateUserSuccess = $"Success to update user."; 
        public static string UserNotExist = $"User doesn't exist.";

        public static string GroupsBelongingRoleNotFound = "Groups belongig role not found.";
        public static string GroupsBelongingRoleSuccess = "Groups belongig role listed succesfully."; 
        public static string GroupsBelongingUserNotFound = "Groups belongig user not found.";
        public static string GroupsBelongingUserSuccess = "Groups belongig user listed succesfully."; 

        public static string GroupsWithoutAssignRolesNotFound = "Groups without assigned roles not found.";
        public static string GroupsWithoutAssignRolesSuccess = "Groups without assigned roles listed succesfully.";
        public static string GroupsWithoutAssignUsersNotFound = "Groups without assigned users not found.";
        public static string GroupsWithoutAssignUsersSuccess = "Groups without assigned users listed succesfully.";


    }
}
