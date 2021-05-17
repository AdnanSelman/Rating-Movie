using System;

namespace MovieRatingTask.Data.Models
{
    public class Rating
    {
        public Rating()
        {
            Id = new Guid();
        }
        public Rating(int stars, Guid movieId)
        {
            Stars = stars;
            MovieShowId = movieId;
        }
        public Guid Id { get; set; }

        public Guid MovieShowId { get; set; }

        public MovieShow MovieShow { get; set; }
        
        public double Stars { get; set; }
    }
}