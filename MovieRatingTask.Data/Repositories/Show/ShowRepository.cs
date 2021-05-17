using Microsoft.EntityFrameworkCore;
using MovieRatingTask.Data.Context;
using MovieRatingTask.Data.Enumerations;
using MovieRatingTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieRatingTask.Data.Repositories.Show
{
    public class ShowRepository : IShowRepository
    {
        private readonly DatabaseContext _database;

        public ShowRepository(DatabaseContext database)
        {
            _database = database;
        }

        public IEnumerable<MovieShow> GetShows(string searchQuery)
        {
            IQueryable<MovieShow> collection;

            collection = _database.Set<MovieShow>().Where(x => x.Type.Name == MovieShowTypeEnumeration.Show.ToString()).Include(p => p.MovieShowRatings).OrderBy(x => x.MovieShowRatings.Average(y => y.Stars));

            if (!string.IsNullOrEmpty(searchQuery))
            {
                if (searchQuery.Contains("stars"))
                {
                    if (searchQuery.Contains("at least"))
                    {
                        collection = collection.Where(x => x.MovieShowRatings.Average(y => y.Stars) >= 3);
                        return collection;
                    }
                    collection = collection.Where(x => x.MovieShowRatings.Average(y => y.Stars) > 2);
                    return collection;
                }
                if (searchQuery.Contains("after"))
                {
                    collection = collection.Where(x => x.ReleaseDate.Year > 2015);
                    return collection;
                }
                if (searchQuery.Contains("older"))
                {
                    collection = collection.Where(x => x.ReleaseDate.Year < DateTime.Now.Year - 5);
                    return collection;
                }
                var search = searchQuery.Trim().ToLower();
                collection = collection.Where(x => x.Title.ToLower().Contains(search));
            }

            return collection;
        }
    }
}