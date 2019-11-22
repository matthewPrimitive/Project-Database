using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Review
    {
        public int ReviewId { get; }

        public int MovieId { get; }

        public int ViewerId { get; }

        public string ReviewMessage { get; }

        public decimal Rating { get; }

        public Review (int reviewid, int movieid, int viewerid, string reviewmessage, decimal rating)
        {
            ReviewId = reviewid;
            MovieId = movieid;
            ViewerId = viewerid;
            ReviewMessage = reviewmessage;
            Rating = rating;
        }
    }
}
