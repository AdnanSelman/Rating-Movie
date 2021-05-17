using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTask.Data.Models
{
    public class CastActor
    {
        public Guid Id { get; set; }

        public Guid ActorId { get; set; }

        public Actor Actor { get; set; }

        public Guid CastId { get; set; }

        public Cast Cast { get; set; }
    }
}