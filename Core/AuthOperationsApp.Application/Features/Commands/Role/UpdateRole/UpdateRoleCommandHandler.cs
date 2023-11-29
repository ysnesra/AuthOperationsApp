
using AuthOperationsApp.Application.Abstractions.Services;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.Role.UpdateRole
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommandRequest, UpdateRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public UpdateRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<UpdateRoleCommandResponse> Handle(UpdateRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var updateRole=await _roleService.UpdateAsync(request, cancellationToken);
            return new UpdateRoleCommandResponse(updateRole);
        }
    }
}
