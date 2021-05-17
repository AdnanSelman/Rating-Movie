using MovieRatingTask.Data.Models;
using System.Collections.Generic;

namespace MovieRatingTask.Data.Repositories.Show
{
    public interface IShowRepository
    {
        IEnumerable<MovieShow> GetShows(string searchQuery);
    }
}