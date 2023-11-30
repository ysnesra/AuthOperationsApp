
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleNoGroup
{
    public class GetAllRoleNoGroupQueryRequest : IRequest<GetAllRoleNoGroupQueryResponse>
    {
        public Guid GroupId { get; set; }
    }
}
