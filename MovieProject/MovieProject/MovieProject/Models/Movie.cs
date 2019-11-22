using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Movie
    {
        public int MovieId { get; }

        public string Name { get; }

        public string Genre { get; }

        public decimal Rating { get; }

        public string Director { get; }

        public Movie (int movieId, string name, string genre, decimal rating, string director)
        {
            MovieId = movieId;
            Name = name;
            Genre = genre;
            Rating = rating;
            Director = director;
        }
    }
}
