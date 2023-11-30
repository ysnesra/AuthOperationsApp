using AuthOperationsApp.Application.Abstractions.Services;
using MediatR;


namespace AuthOperationsApp.Application.Features.Commands.Group.UpdateGroup
{
    
    public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommandRequest, UpdateGroupCommandResponse>
    {
        private readonly IGroupService _groupService;

        public UpdateGroupCommandHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<UpdateGroupCommandResponse> Handle(UpdateGroupCommandRequest request, CancellationToken cancellationToken)
        {
            var updateRole = await _groupService.UpdateAsync(request, cancellationToken);
            return new UpdateGroupCommandResponse(updateRole);
        }
    }
}
