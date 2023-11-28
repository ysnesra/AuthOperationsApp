using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public class RoleGroupWriteRepository : WriteRepository<RoleGroup>, IRoleGroupWriteRepository
    {
        public RoleGroupWriteRepository(AuthOperationsAppDbContext context) : base(context)
        {
        }
    }
}
