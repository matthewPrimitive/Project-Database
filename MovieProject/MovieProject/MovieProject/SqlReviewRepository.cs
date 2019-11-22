using System;
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

        public ShowTime FetchReview(int reviewId)
        {
            var d = new FetchReviewDataDelegate(reviewId);
            return executor.ExecuteReader(d);
        }

        public ShowTime FetchMovieReviews(int movieId)
        {
            var d = new FetchMovieReviewsDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }

        public ShowTime RetrieveMovieReviews(string movieName)
        {
            var d = new RetrieveMovieReviewsDataDelegate(movieName);
            return executor.ExecuteReader(d);
        }

        public ShowTime FetchViewerReviews(int viewerId)
        {
            var d = new FetchViewerReviewsDataDelegate(viewerId);
            return executor.ExecuteReader(d);
        }
    }
}
