using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;

namespace MovieProject.DataDelegates
{
    public class FetchMovieDataDelegate : DataReaderDelegate<Movie>
    {
        private readonly int movieId;

        public FetchMovieDataDelegate(int movieId)
            : base("Movie.FetchMovie")
        {
            this.movieId = movieId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieId", movieId);
        }

        public override Movie Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(movieId.ToString());

            return new Movie(movieId,
                reader.GetString("Name"),
                reader.GetString("Genre"),
                reader.GetDecimal("Rating"),
                reader.GetString("Director"));
        }
    }
}
