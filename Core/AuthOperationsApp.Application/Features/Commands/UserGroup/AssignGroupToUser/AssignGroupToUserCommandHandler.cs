

using AuthOperationsApp.Application.Abstractions.Services;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.AssignGroupToUser
{
    public class AssignGroupToUserCommandHandler : IRequestHandler<AssignGroupToUserCommandRequest, AssignGroupToUserCommandResponse>
    {
        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public AssignGroupToUserCommandHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<AssignGroupToUserCommandResponse> Handle(AssignGroupToUserCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _userGroupService.AssignGroupToUserAsync(request.GroupId, request.UserId);
            return new AssignGroupToUserCommandResponse(response);
        }
    }
}
