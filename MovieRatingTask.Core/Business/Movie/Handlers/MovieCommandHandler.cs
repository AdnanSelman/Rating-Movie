using MediatR;
using MovieRatingTask.Core.Business.Movie.Commands;
using MovieRatingTask.Data.Context;
using MovieRatingTask.Data.Models;
using MovieRatingTask.Data.Repositories.Movie;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRatingTask.Core.Business.Movie.Handlers
{
    public class MovieCommandHandler : IRequestHandler<AddStarsForMovieCommand, bool>
    {
        private readonly IMovieRepository _movieRepository;
        private readonly DatabaseContext _database;

        public MovieCommandHandler(IMovieRepository movieRepository, DatabaseContext database)
        {
            _movieRepository = movieRepository;
            _database = database;
        }

        public Task<bool> Handle(AddStarsForMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = _movieRepository.GetMovieWithId(request.MovieId);
            if (movie == null)
            {
                return Task.FromResult(false);
            }
            var rating = new Rating(request.Stars, movie.Id);
            _database.MovieShowRatings.AddAsync(rating);

            movie.MovieShowRatings.Add(rating);
            _movieRepository.UpdateMovie(movie);
            _database.SaveChanges();

            return Task.FromResult(true);
        }
    }
}