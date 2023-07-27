using System.Net;
using AutoMapper;
using DogApp.Application.Queries;
using Gb.Application.Dtos.Comments;
using Gb.Application.Helpers;
using Gb.Application.Requests.Comments;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CommentsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateComment([FromBody] AddCommentDto addCommentDto, CancellationToken cancellationToken)
        {
            var addCommentRequest = _mapper.Map<AddCommentRequest>(addCommentDto);
            Guid addedId = await _mediator.Send(addCommentRequest, cancellationToken);

            return StatusCode((int)HttpStatusCode.Created, new { id = addedId });
        }

        [HttpGet]
        public async Task<ActionResult> GetComments([FromQuery] PaginationQuery paginationQuery, CancellationToken cancellationToken)
        {
            int totalComments = await _mediator.Send(new GetCountOfCommentsRequest(), cancellationToken);
            var pageSettings = PaginationHelper.CreatePageSettings(paginationQuery.PageNumber, paginationQuery.PageSize, totalComments);
            var comments = await _mediator.Send(new GetCommentsRequest(pageSettings.PageNumber, pageSettings.PageSize), cancellationToken);

            var commentsDto = _mapper.Map<List<CommentDto>>(comments);

            return OkPagedResult(commentsDto, pageSettings.PageNumber, pageSettings.PageSize, totalComments, pageSettings.TotalPages);
        }
    }
}
