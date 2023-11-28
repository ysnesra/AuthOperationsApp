using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Contexts;


namespace AuthOperationsApp.Persistence.Repositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(AuthOperationsAppDbContext context) : base(context)
        {

        }
    }
}

