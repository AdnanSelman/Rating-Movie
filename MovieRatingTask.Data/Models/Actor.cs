using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTask.Data.Models
{
    public class Actor
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<MovieShow> MovieShows { get; set; }
    }
}