using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities.Common;
using AuthOperationsApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AuthOperationsApp.Persistence.Repositories
{
    public abstract class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly AuthOperationsAppDbContext _context;
        private IReadRepository<T> _readRepositoryImplementation;

        public ReadRepository(AuthOperationsAppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return query;
        }

        public IQueryable<T> GetAllDetailQueryable(
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IQueryable<T>>? include = null,
            Expression<Func<T, T>>? selector = null,
            bool enableTracking = true,
            CancellationToken cancellationToken = default)
        {
            IQueryable<T> queryable = Table;

            if (!enableTracking)
                queryable = queryable.AsNoTracking();

            if (include != null)
                queryable = include(queryable);

            if (predicate != null)
                queryable = queryable.Where(predicate);

            if (orderBy != null)
                queryable = orderBy(queryable);

            if (selector != null)
                queryable = queryable.Select(selector);

            return queryable;
        }

        public async Task<IEnumerable<T>?> GetAllDetailAsync(
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IQueryable<T>>? include = null,
            Expression<Func<T, T>>? selector = null,
            bool enableTracking = true,
            CancellationToken cancellationToken = default)
        {
            return await GetAllDetailQueryable(predicate, orderBy, include, selector, enableTracking, cancellationToken).ToListAsync(cancellationToken);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            IQueryable<T> queryable = Table;

            if (!tracking)
                queryable = queryable.AsNoTracking();

            var query = Table.Where(method);
            return query;
        }

        public async Task<T?> GetFirstAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            T? model = await query.Where(method).FirstOrDefaultAsync();
            return model;
        }
        public async Task<T?> GetByIdAsync(Guid id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            T? model = await query.FirstOrDefaultAsync(data => data.Id == id);
            return model;
        }

        public IQueryable<T?> GetFirst(Expression<Func<T, bool>> method)
        {
            var query = Table.AsQueryable();
            return query.Where(method).Take(1);
        }

        public IQueryable<T?> GetById(Guid id)
        {
            var query = Table.AsQueryable();
            var model = query.Where(data => data.Id == id);
            return model;
        }
    }
}



