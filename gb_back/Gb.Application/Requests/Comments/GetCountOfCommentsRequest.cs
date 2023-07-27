using MediatR;

namespace Gb.Application.Requests.Comments
{
    public record GetCountOfCommentsRequest() : IRequest<int>;
}
