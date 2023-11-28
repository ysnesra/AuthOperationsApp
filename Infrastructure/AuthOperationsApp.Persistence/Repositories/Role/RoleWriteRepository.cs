using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;


namespace AuthOperationsApp.Persistence.Repositories
{
    public class RoleWriteRepository : WriteRepository<Role>, IRoleWriteRepository
    {
        public RoleWriteRepository(AuthOperationsAppDbContext context) : base(context)
        {
        }
    }
}
