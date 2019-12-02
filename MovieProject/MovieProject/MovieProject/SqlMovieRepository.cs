using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates;
using MovieProject.DataDelegates.MovieDelegates;

namespace MovieProject
{
    public class SqlMovieRepository : IMovieRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Movie FetchMovie(int movieId)
        {
            var d = new FetchMovieDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> RetrieveMovie(string name)
        {
            var d = new RetrieveMovieDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> RetrieveGenre(string genre)
        {
            var d = new RetrieveGenreDataDelegate(genre);
            return executor.ExecuteReader(d);
        }
        /*
        public Movie RetrieveRating(string rating)
        {
            var d = new RetrieveRatingDataDelegate(rating);
            return executor.ExecuteReader(d);
        }
        */
        public IReadOnlyList<Movie> RetrieveDirector(string director)
        {
            var d = new RetrieveDirectorDataDelegate(director);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> RetrieveMovies()
        {
            return executor.ExecuteReader(new RetrieveMoviesDataDelegate());
        }
    }
}
