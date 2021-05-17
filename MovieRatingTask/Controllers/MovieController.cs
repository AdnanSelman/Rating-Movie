using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRatingTask.Core.Business.Movie.Commands;
using MovieRatingTask.Core.Business.Movie.Queries;
using System;
using System.Threading.Tasks;

namespace MovieRatingTask.API.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _dispatcher;

        public MovieController(IMediator dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetMoviesQuery query)
        {
            var response = await _dispatcher.Send(query);

            return Ok(response);
        }

        [HttpPut("rate")]
        public async Task<IActionResult> AddStars(AddStarsForMovieCommand command)
        {
            //command.MovieId = movieId;

            var response =
                await _dispatcher.Send(command);

            return Ok(response);
        }
    }
}