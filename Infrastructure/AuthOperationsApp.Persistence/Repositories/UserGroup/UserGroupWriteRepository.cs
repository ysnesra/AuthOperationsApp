using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public class UserGroupWriteRepository : WriteRepository<UserGroup>, IUserGroupWriteRepository
    {
        public UserGroupWriteRepository(AuthOperationsAppDbContext context) : base(context)
        {
        }
    }
}