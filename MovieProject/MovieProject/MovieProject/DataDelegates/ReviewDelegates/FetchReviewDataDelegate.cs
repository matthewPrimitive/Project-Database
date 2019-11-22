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
    public class FetchReviewDataDelegate : DataReaderDelegate<Review>
    {
        private readonly int reviewId;

        public FetchReviewDataDelegate(int reviewId)
            : base("Project.FetchReview")
        {
            this.reviewId = reviewId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ReviewId", reviewId);
        }

        public override Review Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(reviewId.ToString());

            return new Review(reviewId,
                reader.GetInt32("MovieId"),
                reader.GetInt32("ViewerId"),
                reader.GetString("ReviewMessage"),
                reader.GetDecimal("Rating"));
        }
    }
}
