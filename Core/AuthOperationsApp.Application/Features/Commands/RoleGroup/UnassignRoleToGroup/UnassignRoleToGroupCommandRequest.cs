
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignRoleToGroup
{
    public class UnassignRoleToGroupCommandRequest : IRequest<UnassignRoleToGroupCommandResponse>
    {
        public Guid GroupId { get; set; }

        public Guid RoleId { get; set; }
    }
}
