using Gb.Application.Repositories;
using Gb.Domain.DbEntities;
using Gb.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Gb.Infrastructure.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : BaseEntity
    {
        private readonly DbContext _context;

        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<Guid> AddAsync(
            TEntity entity,
            CancellationToken cancellationToken)
        {
            var entry = await _context.AddAsync(entity, cancellationToken);

            return entry.Entity.Id;
        }

        public async Task<int> CountAsync(CancellationToken cancellationToken)
        {
            int count = await _dbSet.CountAsync(cancellationToken);

            return count;
        }

        public async Task<IReadOnlyList<TEntity>> GetRangeAsync(
            CancellationToken cancellationToken,
            int skip = 0,
            int take = 0,
            bool asNoTracking = true)
        {
            var list = await _dbSet.NoTracking(asNoTracking).GetQuery(skip, take).ToListAsync();

            return list;
        }
    }
}