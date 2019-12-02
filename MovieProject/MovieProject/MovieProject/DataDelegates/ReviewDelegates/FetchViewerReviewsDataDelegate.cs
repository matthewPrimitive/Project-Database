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
    public class FetchViewerReviewsDataDelegate : DataReaderDelegate<IReadOnlyList<Review>>
    {
        private readonly int viewerId;

        public FetchViewerReviewsDataDelegate(int viewerId)
            : base("Project.FetchViewerReviews")
        {
            this.viewerId = viewerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ViewerId", viewerId);
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
