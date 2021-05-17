using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTask.Data.Models
{
    public class MovieShowType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<MovieShow> MovieShows { get; set; }
    }
}