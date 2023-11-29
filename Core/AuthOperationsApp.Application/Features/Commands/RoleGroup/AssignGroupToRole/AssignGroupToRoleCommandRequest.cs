using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignGroupToRole
{
    public class AssignGroupToRoleCommandRequest : IRequest<AssignGroupToRoleCommandResponse>
    {
        public Guid GroupId { get; set; }
        public Guid? RoleId { get; set; }
      
    }
}
