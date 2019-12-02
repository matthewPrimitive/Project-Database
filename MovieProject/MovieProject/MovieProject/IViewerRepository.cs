using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieProject.Models;

namespace MovieProject
{
    public interface IViewerRepository
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
        Viewer FetchViewer(int viewerId);

        /// <summary>
        /// Gets the movie with the given <paramref name="movieId"/> if it exists.
        /// </summary>
        /// <param name="movieId">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="movieId"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Viewer RetrieveViewerOnEmail(string email);

        /// <summary>
        /// Gets the movie with the given <paramref name="showTimeId"/> if it exists.
        /// </summary>
        /// <param name="time">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="time"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Viewer RetrieveViewerOnName(string name);

        /// <summary>
        /// Gets the movie with the given <paramref name="date"/> if it exists.
        /// </summary>
        /// <param name="date">name of the movie to get.</param>
        /// <returns>
        /// An instance of <see cref="ShowTime"/> containing the information of the requested showtime
        /// if one exists with with the provided <paramref name="date"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Viewer RetrieveViewerOnGender(string gender);
    }
}
