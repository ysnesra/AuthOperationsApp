

using AuthOperationsApp.Application.DTOs.Group;
using AuthOperationsApp.Application.Features.Commands.Group.UpdateGroup;

namespace AuthOperationsApp.Application.Abstractions.Services
{
    public interface IGroupService
    {
        Task<List<GroupListDto?>> GetAllGroupAsync();
        Task<GroupByIdDto> GetGroupByIdAsync(Guid id, bool tracking = true);
        Task<UpdateGroupInfoDto> UpdateAsync(UpdateGroupCommandRequest request,
         CancellationToken cancellationToken, bool tracking = false);
    }
}
