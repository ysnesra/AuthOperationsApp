
using AuthOperationsApp.Application.Abstractions.Services;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignRoleToGroup
{
    public class UnassignRoleToGroupCommandHandler : IRequestHandler<UnassignRoleToGroupCommandRequest, UnassignRoleToGroupCommandResponse>
    {

        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;

        public UnassignRoleToGroupCommandHandler(IRoleGroupService roleGroupService, IMapper mapper)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
        }

        public async Task<UnassignRoleToGroupCommandResponse> Handle(UnassignRoleToGroupCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _roleGroupService.UnassignRoleToGroupAsync(request.GroupId, request.RoleId);
            return new UnassignRoleToGroupCommandResponse(response);
        }
    }
}
