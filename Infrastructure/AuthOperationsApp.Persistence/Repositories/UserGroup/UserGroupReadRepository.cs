using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public class UserGroupReadRepository : ReadRepository<UserGroup>, IUserGroupReadRepository
    {
        public UserGroupReadRepository(AuthOperationsAppDbContext context) : base(context)
        {

        }
    }
}