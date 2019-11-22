using System;
namespace MovieProject
{
    public interface IActorRepository
    {
        /// <summary>
        /// Retrieves all ShowTimes in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Actor}"/> containing all showtimes.
        /// </returns>
        IReadOnlyList<Actor> FetchActor();

        /// <summary>
        /// Fetches the movie with the given <paramref name="viewerId"/> if it exists.
        /// </summary>
        /// <param name="viewerId">Identifier of the movie to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Viewer"/> containing the information of the requested showtime.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="viewerId"/> does not exist.
        /// </exception>
        Actor FetchActor(int actorId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="movieId"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Actor FetchActorOnName(string name);
    }
}
