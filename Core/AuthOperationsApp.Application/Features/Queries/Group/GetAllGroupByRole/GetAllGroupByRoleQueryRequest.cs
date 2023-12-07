using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole
{
    public class GetAllGroupByRoleQueryRequest : IRequest<GetAllGroupByUserQueryResponse>
    {
        public Guid RoleId { get; set; }
    }
}
