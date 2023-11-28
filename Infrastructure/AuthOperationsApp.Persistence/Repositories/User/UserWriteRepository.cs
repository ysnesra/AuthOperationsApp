using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(AuthOperationsAppDbContext context) : base(context)
        {
        }
    }
}