
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.AssignGroupToUser
{
    public class AssignGroupToUserCommandRequest : IRequest<AssignGroupToUserCommandResponse>
    {
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
    }
}
