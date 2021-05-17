using MediatR;
using System;

namespace MovieRatingTask.Core.Business.Movie.Commands
{
    public class AddStarsForMovieCommand : IRequest<bool>
    {
        public int Stars { get; set; }
        public Guid MovieId { get; set; }
    }
}