using System.Collections;
using Gb.Application.Models;
using Microsoft.AspNetCore.Mvc;


namespace Gb.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        protected static ActionResult OkPagedResult<T>(
            T data, int PageNumber, int PageSize, int totalItems, int totalPages) where T : IEnumerable
        {
            var pagedResponse = new PagedResponse<T>(data)
            {
                PageNumber = PageNumber + 1,
                PageSize = PageSize,
                TotalItems = totalItems,
                TotalPages = totalPages
            };

            return new OkObjectResult(pagedResponse);
        }
    }
}