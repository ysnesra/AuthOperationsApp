using AuthOperationsApp.Application.Abstractions.Services;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignGroupToRole
{
    public class UnassignGroupToRoleCommandHandler : IRequestHandler<UnassignGroupToRoleCommandRequest, UnassignGroupToRoleCommandResponse>
    {

        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;

        public UnassignGroupToRoleCommandHandler(IRoleGroupService roleGroupService, IMapper mapper)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
        }

        public async Task<UnassignGroupToRoleCommandResponse> Handle(UnassignGroupToRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _roleGroupService.UnassignGroupToRoleAsync(request.GroupId, request.RoleId);
            return new UnassignGroupToRoleCommandResponse(response);
        }
    }
}

