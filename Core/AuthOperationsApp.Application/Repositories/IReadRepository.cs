using AuthOperationsApp.Domain.Entities.Common;
using System.Linq.Expressions;


namespace AuthOperationsApp.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetAllDetailQueryable(
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IQueryable<T>>? include = null,
            Expression<Func<T, T>>? selector = null,
            bool enableTracking = true,
            CancellationToken cancellationToken = default);

        Task<IEnumerable<T>?> GetAllDetailAsync(
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            Func<IQueryable<T>, IQueryable<T>>? include = null,
            Expression<Func<T, T>>? selector = null,
            bool enableTracking = true,
            CancellationToken cancellationToken = default);

        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetFirstAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(Guid id, bool tracking = true);
        IQueryable<T?> GetFirst(Expression<Func<T, bool>> method);
        IQueryable<T?> GetById(Guid id);

    }
}

