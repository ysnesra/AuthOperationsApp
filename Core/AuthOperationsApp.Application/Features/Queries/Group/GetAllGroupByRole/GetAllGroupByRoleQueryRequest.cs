using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole
{
    public class GetAllGroupByRoleQueryRequest : IRequest<GetAllGroupByRoleQueryResponse>
    {
        public Guid RoleId { get; set; }
    }
}
