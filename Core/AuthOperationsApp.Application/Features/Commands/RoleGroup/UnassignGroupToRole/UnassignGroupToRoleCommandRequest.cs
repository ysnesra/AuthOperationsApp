using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignGroupToRole
{
    public class UnassignGroupToRoleCommandRequest : IRequest<UnassignGroupToRoleCommandResponse>
    {
        public Guid GroupId { get; set; }

        public Guid RoleId { get; set; }
    }
}
