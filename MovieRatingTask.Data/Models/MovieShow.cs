using System;
using System.Collections.Generic;

namespace MovieRatingTask.Data.Models
{
    public class MovieShow
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CoverImageUrl { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Guid TypeId { get; set; }

        public MovieShowType  Type { get; set; }

        public CastMovie CastMovie { get; set; }

        public ICollection<Rating> MovieShowRatings { get; set; }
    }
}