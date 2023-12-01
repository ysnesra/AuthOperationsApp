
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.AssignUserToGroup
{
    public class AssignUserToGroupCommandRequest : IRequest<AssignUserToGroupCommandResponse>
    {
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
    }
}
