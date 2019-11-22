using System;
namespace MovieProject
{
    public interface IReviewRepository
    {
        /// <summary>
        /// Retrieves all Reviews in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Review}"/> containing all Reviews.
        /// </returns>
        IReadOnlyList<ShowTime> FetchReview();

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
        Review FetchReveiw(int reviewId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Review"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="movieId"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Review FetchMovieReviews(int movieId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieName"/> if it exists.
        /// </summary>
        /// <param name="movieName">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Review"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="time"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Review RetrieveMovieReviews(string movieName);

        /// <summary>
        /// Gets the movie with the given <paramref name="viewerId"/> if it exists.
        /// </summary>
        /// <param name="viewerId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Review"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="date"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Review FetchViewerReviews(int viewerId);
    }
}
