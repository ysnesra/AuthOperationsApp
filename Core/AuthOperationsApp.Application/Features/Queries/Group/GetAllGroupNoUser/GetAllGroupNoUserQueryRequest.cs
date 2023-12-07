
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupNoUser
{
    public class GetAllGroupNoUserQueryRequest : IRequest<GetAllGroupNoUserQueryResponse>
    {
        public Guid UserId { get; set; }
    }
}
