namespace Gb.Application.Repositories
{
    public interface IRepositoryWrapper
    {
        ICommentRepository Comments { get; }

        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}