using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Models;

namespace MovieProject
{
    public interface IReviewRepository
    {

        /// <summary>
        /// Fetches the review with the given <paramref name="reviewId"/> if it exists.
        /// </summary>
        /// <param name="reviewId">Identifier of the movie to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Reveiw"/> containing the information of the requested showtime.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="showTimeId"/> does not exist.
        /// </exception>
        Review FetchReview(int reviewId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Review"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="movieId"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Review> FetchMovieReviews(int movieId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieName"/> if it exists.
        /// </summary>
        /// <param name="movieName">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Review"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="time"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Review> RetrieveMovieReviews(string movieName);

        /// <summary>
        /// Gets the movie with the given <paramref name="viewerId"/> if it exists.
        /// </summary>
        /// <param name="viewerId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Review"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="date"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Review> FetchViewerReviews(int viewerId);

        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="viewerid">The viewer id</param>
        /// <param name="movieId">The movie id</param>
        /// <param name="rating">The rating of the movie</param>
        /// <param name="review">The review of the movie</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        Review CreateReview(int viewerId, int movieId, decimal rating, string review);
    }
}
