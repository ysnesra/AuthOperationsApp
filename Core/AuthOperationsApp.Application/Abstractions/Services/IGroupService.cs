

using AuthOperationsApp.Application.DTOs.Group;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IGroupService
    {
        Task<List<GroupListDto?>> GetAllGroupAsync();
    }
}
