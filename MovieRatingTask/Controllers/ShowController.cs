using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRatingTask.Core.Business.Show.Queries;
using System.Threading.Tasks;

namespace MovieRatingTask.API.Controllers
{
    [ApiController]
    [Route("api/shows")]
    public class ShowController : ControllerBase
    {
        private readonly IMediator _dispatcher;

        public ShowController(IMediator dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetShowsQuery query)
        {
            var response = await _dispatcher.Send(query);

            return Ok(response);
        }
    }
}