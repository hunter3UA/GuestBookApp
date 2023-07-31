using Gb.Application.Repositories;
using Gb.Application.Requests.Comments;
using MediatR;

namespace Gb.Application.Handlers.Comments
{
    public sealed class GetCountOfCommentsHandler : IRequestHandler<GetCountOfCommentsRequest, int>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public GetCountOfCommentsHandler(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<int> Handle(GetCountOfCommentsRequest request, CancellationToken cancellationToken)
        {
            var count = await _repositoryWrapper.Comments.CountAsync(cancellationToken);

            return count;
        }
    }
}