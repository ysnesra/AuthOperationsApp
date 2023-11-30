using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignRoleToGroup
{
    public class AssignRoleToGroupCommandRequest : IRequest<AssignRoleToGroupCommandResponse>
    {
        public Guid GroupId { get; set; }
        public Guid RoleId { get; set; }

    }
}
