
using AuthOperationsApp.Application.Abstractions.Services;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.AssignUserToGroup
{
    public class AssignUserToGroupCommandHandler : IRequestHandler<AssignUserToGroupCommandRequest, AssignUserToGroupCommandResponse>
    {
        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public AssignUserToGroupCommandHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<AssignUserToGroupCommandResponse> Handle(AssignUserToGroupCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _userGroupService.AssignUserToGroupAsync(request.GroupId, request.UserId);
            return new AssignUserToGroupCommandResponse(response);
        }
    }
}
