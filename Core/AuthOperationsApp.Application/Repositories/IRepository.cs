using AuthOperationsApp.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;


namespace AuthOperationsApp.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
