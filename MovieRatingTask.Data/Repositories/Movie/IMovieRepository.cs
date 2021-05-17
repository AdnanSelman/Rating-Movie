using MovieRatingTask.Data.Models;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRatingTask.Data.Repositories.Movie
{
    public interface IMovieRepository
    {
        IQueryable<MovieShow> GetMovies(string searchQuery);

        MovieShow GetMovieWithId(Guid id);

        void UpdateMovie(MovieShow movie);
    }
}