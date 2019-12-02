using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates.ReviewDelegates;

namespace MovieProject
{
    public class SqlReviewRepository : IReviewRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlReviewRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Review CreateReview(int viewerId, int movieId, decimal rating, string review)
        {
            var d = new CreateReviewDataDelegate(viewerId, movieId, review, rating);
            return executor.ExecuteNonQuery(d);
        }

        public Review FetchReview(int reviewId)
        {
            var d = new FetchReviewDataDelegate(reviewId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Review> FetchMovieReviews(int movieId)
        {
            var d = new FetchMovieReviewsDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Review> RetrieveMovieReviews(string movieName)
        {
            var d = new RetrieveMovieReviewsDataDelegate(movieName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Review> FetchViewerReviews(int viewerId)
        {
            var d = new FetchViewerReviewsDataDelegate(viewerId);
            return executor.ExecuteReader(d);
        }
    }
}
