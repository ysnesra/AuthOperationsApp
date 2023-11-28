using AuthOperationsApp.Domain.Entities.Common;


namespace AuthOperationsApp.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        Task<bool> RemoveAsync(string id);
        Task<bool> RemoveAsync(Guid id);
        bool RemoveRange(List<T> datas);
        bool Remove(T model);
        bool Update(T model);
        Task<int> SaveAsync();

    }
}
