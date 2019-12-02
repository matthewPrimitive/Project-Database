using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;


namespace MovieProject
{
    public interface IMovieRepository
    {
        /// <summary>
        /// Retrieves all movies in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Movie}"/> containing all movies.
        /// </returns>
        IReadOnlyList<Movie> RetrieveMovies();

        /// <summary>
        /// Fetches the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">Identifier of the movie to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Movie"/> containing the information of the requested movie.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="movieId"/> does not exist.
        /// </exception>
        Movie FetchMovie(int movieId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="name">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Movie"/> containing the information of the requested movie
        /// if one exists with with the provided <paramref name="name"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Movie> RetrieveMovie(string name);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="genre">genre of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Movie"/> containing the information of the requested movie
        /// if one exists with with the provided <paramref name="genre"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Movie> RetrieveGenre(string genre);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="rating">genre of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Movie"/> containing the information of the requested movie
        /// if one exists with with the provided <paramref name="rating"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        //IReadOnlyList<Movie> RetrieveRating(string rating);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="director">genre of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="Movie"/> containing the information of the requested movie
        /// if one exists with with the provided <paramref name="director"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Movie> RetrieveDirector(string director);
    }
}
