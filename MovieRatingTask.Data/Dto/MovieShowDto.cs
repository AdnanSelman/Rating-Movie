using MovieRatingTask.Data.Models;
using System;
using System.Collections.Generic;

namespace MovieRatingTask.Data.Dto
{
    public class MovieShowDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string CoverImageUrl { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<Actor> Actors { get; set; }

        public double Average { get; set; }
    }
}