using MediatR;


namespace AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignUserToGroup
{
    public class UnassignUserToGroupCommandRequest : IRequest<UnassignUserToGroupCommandResponse>
    {
        public Guid GroupId { get; set; }

        public Guid UserId { get; set; }
    }
}
