using AutoMapper;
using Gb.Application.Repositories;
using Gb.Application.Requests.Comments;
using Gb.Domain.DbEntities;
using MediatR;

namespace Gb.Application.Handlers.Comments
{
    public sealed class AddCommentHandler : IRequestHandler<AddCommentRequest, Guid>
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public AddCommentHandler(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(AddCommentRequest request, CancellationToken cancellationToken)
        {
            var commentToAdd = _mapper.Map<CommentDb>(request);

            var addedId = await _repositoryWrapper.Comments.AddAsync(commentToAdd, cancellationToken);
            await _repositoryWrapper.SaveChangesAsync(cancellationToken);

            return addedId;
        }
    }
}