using Gb.Domain.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace Gb.Infrastructure.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TEntity> GetQuery<TEntity>(
            this IQueryable<TEntity> query,
            int skip = default,
            int take = default)
            where TEntity : BaseEntity
        {
            if (skip != default)
                query = query.Skip(skip);

            if (take != default)
                query = query.Take(take);

            return query;
        }

        public static IQueryable<TEntity> NoTracking<TEntity>(
           this IQueryable<TEntity> query,
           bool asNoTracking)
           where TEntity : BaseEntity
        {
            return asNoTracking ? query.AsNoTracking() : query;
        }
    }
}