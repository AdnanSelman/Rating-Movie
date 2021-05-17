using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTask.Data.Models
{
    public class CastMovie
    {
        public Guid Id { get; set; }
        public Guid MovieShowId { get; set; }
        public MovieShow MovieShow { get; set; }
        public Cast Cast { get; set; }
        public Guid CastId { get; set; }
    }
}
