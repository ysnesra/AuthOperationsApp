

using AuthOperationsApp.Application.Abstractions.Services;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignUserToGroup
{
    public class UnassignUserToGroupCommandHandler : IRequestHandler<UnassignUserToGroupCommandRequest, UnassignUserToGroupCommandResponse>
    {

        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public UnassignUserToGroupCommandHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<UnassignUserToGroupCommandResponse> Handle(UnassignUserToGroupCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _userGroupService.UnassignUserToGroupAsync(request.GroupId, request.UserId);
            return new UnassignUserToGroupCommandResponse(response);
        }
    }
}
