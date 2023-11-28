using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public class GroupReadRepository : ReadRepository<Group>, IGroupReadRepository
    {
        public GroupReadRepository(AuthOperationsAppDbContext context) : base(context)
        {

        }
    }
}
