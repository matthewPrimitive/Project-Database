using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class MovieActor
    {
        public int MovieActorId { get; }

        public int ActorId { get; }

        public int MovieId { get; }

        public MovieActor(int movieactorid, int movieid, int actorid)
        {
            MovieActorId = movieactorid;
            MovieId = movieid;
            ActorId = actorid;
        } 
    }
}
