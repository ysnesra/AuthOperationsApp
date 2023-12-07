
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignGroupToUser
{
    public class UnassignGroupToUserCommandRequest : IRequest<UnassignGroupToUserCommandResponse>
    {
        public Guid GroupId { get; set; }

        public Guid UserId { get; set; }
    }
}
