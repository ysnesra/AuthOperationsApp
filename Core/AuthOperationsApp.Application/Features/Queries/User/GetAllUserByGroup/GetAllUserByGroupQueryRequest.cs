using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUserByGroup
{
    public class GetAllUserByGroupQueryRequest : IRequest<GetAllUserByGroupQueryResponse>
    {
        public Guid GroupId { get; set; }
    }
}
