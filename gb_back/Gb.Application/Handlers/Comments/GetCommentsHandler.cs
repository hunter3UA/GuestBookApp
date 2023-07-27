using AutoMapper;
using Gb.Application.Repositories;
using Gb.Application.Requests.Comments;
using Gb.Domain.Entities;
using MediatR;

namespace Gb.Application.Handlers.Comments
{
    public sealed class GetCommentsHandler : IRequestHandler<GetCommentsRequest, List<CommentEntity>>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public GetCommentsHandler(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        public async Task<List<CommentEntity>> Handle(GetCommentsRequest request, CancellationToken cancellationToken)
        {
            var listOfComments = await _repositoryWrapper.Comments.GetRangeAsync(cancellationToken, request.Skip, request.Take);

            return _mapper.Map<List<CommentEntity>>(listOfComments);
        }
    }
}
