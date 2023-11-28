using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public class GroupWriteRepository : WriteRepository<Group>, IGroupWriteRepository
    {
        public GroupWriteRepository(AuthOperationsAppDbContext context) : base(context)
        {
        }
    }
}
