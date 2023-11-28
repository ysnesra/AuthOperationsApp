using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Persistence.Contexts;


namespace AuthOperationsApp.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuthOperationsAppDbContext _context;

        private bool _isCommit = true;

        public bool IsCommit => _isCommit;

        public UnitOfWork(AuthOperationsAppDbContext context)
        {
            _context = context;
        }

        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            _isCommit = true;
        }

        public async Task RollbackAsync(CancellationToken cancellationToken = default)
        {
            _isCommit = false;
        }

        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {

        }

        public ValueTask DisposeAsync()
        {
            return ValueTask.CompletedTask;
        }
    }
}
