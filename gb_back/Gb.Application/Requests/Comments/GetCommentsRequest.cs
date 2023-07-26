using Gb.Domain.Entities;
using MediatR;

namespace Gb.Application.Requests.Comments
{
    public sealed record GetCommentsRequest(int Skip, int Take) : IRequest<List<CommentEntity>>;
}
