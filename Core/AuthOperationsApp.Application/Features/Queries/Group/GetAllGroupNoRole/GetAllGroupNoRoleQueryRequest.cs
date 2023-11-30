using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupNoRole
{
    public class GetAllGroupNoRoleQueryRequest : IRequest<GetAllGroupNoRoleQueryResponse>
    {
        public Guid RoleId { get; set; }
    }
}
