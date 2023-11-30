using AuthOperationsApp.Application.Abstractions.Services;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignRoleToGroup
{
    public class AssignRoleToGroupCommandHandler : IRequestHandler<AssignRoleToGroupCommandRequest, AssignRoleToGroupCommandResponse>
    {
        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;

        public AssignRoleToGroupCommandHandler(IRoleGroupService roleGroupService, IMapper mapper)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
        }

        public async Task<AssignRoleToGroupCommandResponse> Handle(AssignRoleToGroupCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _roleGroupService.AssignRoleToGroupAsync(request.GroupId, request.RoleId);
            return new AssignRoleToGroupCommandResponse(response);
        }
    }
}
