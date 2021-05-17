using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using MovieRatingTask.Data.Context;
using MovieRatingTask.Data.Dto;
using MovieRatingTask.Data.Enumerations;
using MovieRatingTask.Data.Models;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRatingTask.Data.Repositories.Movie
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IMapper _mapper;
        private readonly DatabaseContext _database;

        public MovieRepository(DatabaseContext database, IMapper mapper)
        {
            _database = database;
            _mapper = mapper;
        }

        public IQueryable<MovieShow> GetMovies(string searchQuery)
        {
            IQueryable<MovieShow> collection;

            collection = _database.Set<MovieShow>().Where(x => x.Type.Name == MovieShowTypeEnumeration.Movie.ToString()).Include(p => p.MovieShowRatings).Include(s => s.Type).Include(s => s.CastMovie).ThenInclude(c => c.Cast).ThenInclude(k => k.CastActors).ThenInclude(a => a.Actor).OrderBy(x => x.MovieShowRatings.Average(y => y.Stars));

            if (!string.IsNullOrEmpty(searchQuery))
            {
                if (searchQuery.Contains("stars"))
                {
                    if(searchQuery.Contains("at least"))
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

        public MovieShow GetMovieWithId(Guid id)
        {
            return _database.Set<MovieShow>().Find(id);
        }

        public void UpdateMovie(MovieShow movie)
        {
            if (movie != null) return;
            _database.Set<MovieShow>().UpdateRange(movie);
        }
    }
}