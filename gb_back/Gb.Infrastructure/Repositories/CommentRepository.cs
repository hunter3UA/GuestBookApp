using Gb.Application.Repositories;
using Gb.Domain.DbEntities;
using Gb.Infrastructure.DbContexts;

namespace Gb.Infrastructure.Repositories
{
    public class CommentRepository : RepositoryBase<CommentDb>, ICommentRepository
    {
        public CommentRepository(GbDbContext context) : base(context)
        {
        }
    }
}