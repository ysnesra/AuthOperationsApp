using AuthOperationsApp.Application.Features.Commands.Role.UpdateRole;
using MediatR;

namespace AuthOperationsApp.Persistence.Services
{
    public class UpdatRoleCommandRequest :IRequest<UpdateRoleCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}