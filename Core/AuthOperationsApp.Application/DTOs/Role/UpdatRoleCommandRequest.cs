using AuthOperationsApp.Application.Features.Commands.Role.UpdateRole;
using MediatR;


namespace AuthOperationsApp.Application.DTOs.Role
{
    public class UpdatRoleCommandRequest : IRequest<UpdateRoleCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
