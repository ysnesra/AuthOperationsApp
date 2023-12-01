

using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUserNoGroup
{
    public class GetAllUserNoGroupQueryRequest : IRequest<GetAllUserNoGroupQueryResponse>
    {
        public Guid GroupId { get; set; }
    }
}
