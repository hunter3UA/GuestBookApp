using MediatR;

namespace Gb.Application.Requests.Comments
{
    public sealed record AddCommentRequest(string Name, string Text) : IRequest<Guid>;
}
