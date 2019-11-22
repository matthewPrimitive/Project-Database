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
    public class RetrieveMovieReviewsDataDelegate : DataReaderDelegate<IReadOnlyList<Review>>
    {
        private readonly string name;

        public RetrieveMovieReviewsDataDelegate(string name)
            : base("Movie.RetrieveMovieReviews")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override IReadOnlyList<Review> Translate(SqlCommand command, IDataRowReader reader)
        {
            var reviews = new List<Review>();

            while (reader.Read())
            {
                reviews.Add(new Review(
                    reader.GetInt32("ReviewId"),
                    reader.GetInt32("MovieId"),
                    reader.GetInt32("ViewerId"),
                    reader.GetString("ReviewMessage"),
                    reader.GetDecimal("Rating")));
            }

            return reviews;
        }
    }
}
