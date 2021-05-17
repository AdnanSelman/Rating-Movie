using Microsoft.EntityFrameworkCore;
using MovieRatingTask.Data.Models;

namespace MovieRatingTask.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieShow> MovieShows { get; set; }
        public DbSet<MovieShowActor> MovieShowActors { get; set; }
        public DbSet<Rating> MovieShowRatings { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<CastActor> CastActors { get; set; }
        public DbSet<CastMovie> CastMovies { get; set; }
        public DbSet<MovieShowType> MovieShowTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}