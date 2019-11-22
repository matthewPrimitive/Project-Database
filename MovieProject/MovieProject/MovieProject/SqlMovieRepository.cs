using System;
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

        public Movie RetrieveMovie(string name)
        {
            var d = new RetrieveMovieDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public Movie RetrieveGenre(string genre)
        {
            var d = new RetrieveGenreDataDelegate(genre);
            return executor.ExecuteReader(d);
        }

        public Movie RetrieveRating(string rating)
        {
            var d = new RetrieveRatingDataDelegate(rating);
            return executor.ExecuteReader(d);
        }

        public Movie RetrieveDirector(string director)
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
