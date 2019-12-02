using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using System.Data.SqlClient;

namespace MovieProject.DataDelegates.ReviewDelegates
{
    public class CreateReviewDataDelegate : NonQueryDataDelegate<Review>
    {
        public readonly int viewerId;
        public readonly int movieId;
        public readonly string reviewMessage;
        public readonly decimal rating;

        public CreateReviewDataDelegate(int viewerId, int movieId, string reviewMessage, decimal rating)
            : base("Project.CreateReview")
        {
            this.viewerId = viewerId;
            this.movieId = movieId;
            this.reviewMessage = reviewMessage;
            this.rating = rating;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ViewerId", viewerId);
            command.Parameters.AddWithValue("MovieId", movieId);
            command.Parameters.AddWithValue("ReviewMessage", reviewMessage);
            command.Parameters.AddWithValue("Rating", rating);

            var p = command.Parameters.Add("ReviewId", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }

        public override Review Translate(SqlCommand command)
        {
            return new Review((int)command.Parameters["ReviewId"].Value, viewerId, movieId, reviewMessage, rating);
        }
    }
}
