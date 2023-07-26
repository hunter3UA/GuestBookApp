using Gb.Application.Repositories;
using Gb.Infrastructure.DbContexts;

namespace Gb.Infrastructure.Repositories
{
    public sealed class RepositoryWrapper : IRepositoryWrapper
    {
        private GbDbContext _dbContext;

        public ICommentRepository Comments { get; }

        public RepositoryWrapper(GbDbContext dbContext, ICommentRepository comments)
        {
            _dbContext = dbContext;
            Comments = comments;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
