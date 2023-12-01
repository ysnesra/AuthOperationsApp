
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.User.UpdateUser
{
    public class UpdateUserCommandRequest : IRequest<UpdateUserCommandResponse>
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
    }
}
