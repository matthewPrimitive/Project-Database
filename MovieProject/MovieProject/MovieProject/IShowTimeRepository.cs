﻿using System;
namespace MovieProject
{
    public interface IShowTimeRepository
    {
        /// <summary>
        /// Retrieves all ShowTimes in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{ShowTime}"/> containing all showtimes.
        /// </returns>
        IReadOnlyList<ShowTime> FetchShowTime();

        /// <summary>
        /// Fetches the movie with the given <paramref name="showTimeId"/> if it exists.
        /// </summary>
        /// <param name="showTimeId">Identifier of the movie to fetch.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="showTimeId"/> does not exist.
        /// </exception>
        ShowTime FetchShowTime(int showTimeId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="movieId"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        ShowTime RetrieveMovieShowTime(int movieId);

        /// <summary>
        /// Gets the movie with the given <paramref name="showTimeId"/> if it exists.
        /// </summary>
        /// <param name="time">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="time"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        ShowTime RetrieveTimeShowTime(string time);

        /// <summary>
        /// Gets the movie with the given <paramref name="date"/> if it exists.
        /// </summary>
        /// <param name="date">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="date"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        ShowTime RetrieveDateShowTime(string date);
    }
}