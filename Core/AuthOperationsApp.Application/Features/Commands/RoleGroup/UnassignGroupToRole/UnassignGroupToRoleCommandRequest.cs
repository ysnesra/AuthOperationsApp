using AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignGroupToRole;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignGroupToRole
{
    public class UnassignGroupToRoleCommandRequest : IRequest<AssignGroupToRoleCommandRequest>
    {
        public Guid GroupId { get; set; }

        public Guid? RoleId { get; set; }

    }
}
