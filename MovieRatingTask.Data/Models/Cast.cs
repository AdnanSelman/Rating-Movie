using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTask.Data.Models
{
    public class Cast
    {
        public Guid Id { get; set; }

        public CastMovie CastMovie { get; set; }
        public ICollection<CastActor> CastActors { get; set; }
    }
}
