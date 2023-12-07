using AuthOperationsApp.Application.Abstractions.Services;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignGroupToUser
{
    public class UnassignGroupToUserCommandHandler : IRequestHandler<UnassignGroupToUserCommandRequest, UnassignGroupToUserCommandResponse>
    {

        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public UnassignGroupToUserCommandHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<UnassignGroupToUserCommandResponse> Handle(UnassignGroupToUserCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _userGroupService.UnassignGroupToUserAsync(request.GroupId, request.UserId);
            return new UnassignGroupToUserCommandResponse(response);
        }
    }
}
