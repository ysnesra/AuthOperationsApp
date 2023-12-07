using AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole;
using MediatR;


namespace AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupByUser
{
    public class GetAllGroupByUserQueryRequest : IRequest<GetAllGroupByUserQueryResponse>
    {
        public Guid UserId { get; set; }
    }
}
