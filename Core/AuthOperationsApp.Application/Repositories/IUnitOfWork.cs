

namespace AuthOperationsApp.Application.Repositories
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        bool IsCommit { get; }
        Task CommitAsync(CancellationToken cancellationToken = default);
        Task RollbackAsync(CancellationToken cancellationToken = default);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
