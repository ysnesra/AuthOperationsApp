using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.Group.UpdateGroup
{
    public class UpdateGroupCommandRequest : IRequest<UpdateGroupCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
