using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public class RoleGroupReadRepository : ReadRepository<RoleGroup>, IRoleGroupReadRepository
    {
        public RoleGroupReadRepository(AuthOperationsAppDbContext context) : base(context)
        {

        }
    }
}