using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Models;

namespace MovieProject
{
    public interface ITicketRepository
    {

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
        Ticket FetchTicket(int ticketId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="movieId"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Ticket> RetrieveViewerTicket(int viewerId);

        /// <summary>
        /// Gets the movie with the given <paramref name="showTimeId"/> if it exists.
        /// </summary>
        /// <param name="time">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="time"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        IReadOnlyList<Ticket> RetrieveShowTimeTicket(int showTimeId);

        /// <summary>
        /// Creates a new person in the repository.
        /// </summary>
        /// <param name="viewerid">The viewer id</param>
        /// <param name="showTimeId">The show time id</param>
        /// <param name="purchasedOn">The time the ticket was purchased</param>
        /// <returns>
        /// The resulting instance of <see cref="Person"/>.
        /// </returns>
        Ticket CreateTicket(int viewerId, int showTimeId);
    }
}
