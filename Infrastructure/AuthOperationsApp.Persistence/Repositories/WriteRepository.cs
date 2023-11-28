using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

using AuthOperationsApp.Persistence.Contexts;

namespace AuthOperationsApp.Persistence.Repositories
{
    public abstract class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly AuthOperationsAppDbContext _context;

        public WriteRepository(AuthOperationsAppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return await RemoveAsync(Guid.Parse(id));
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            T? model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return model != null && Remove(model);
        }

        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();

    }
}

