using System;

namespace MovieRatingTask.Data.Models
{
    public class MovieShowActor
    {
        public Guid Id { get; set; }

        public Guid MovieId { get; set; }

        public MovieShow MovieShow { get; set; }

        public Guid ActorId { get; set; }
        
        public Actor Actor { get; set; }
    }
}