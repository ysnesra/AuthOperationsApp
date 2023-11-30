using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleByGroup
{
    public class GetAllRoleByGroupQueryRequest : IRequest<GetAllRoleByGroupQueryResponse>
    {
        public Guid GroupId { get; set; }
    }
}
