using Gb.Domain.DbEntities;

namespace Gb.Application.Repositories
{
    public interface IRepositoryBase<TEntity>
        where TEntity : BaseEntity
    {
        Task<Guid> AddAsync(
            TEntity entity,
            CancellationToken cancellationToken);

        Task<IReadOnlyList<TEntity>> GetRangeAsync(
            CancellationToken cancellationToken,
            int skip = default,
            int take = default,
            bool asNoTracking = true);

        Task<int> CountAsync(CancellationToken cancellationToken);
    }
}