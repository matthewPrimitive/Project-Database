using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using System.Data.SqlClient;


namespace MovieProject.DataDelegates
{
    public class RetrieveMovieDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        private readonly string moviename;

        public RetrieveMovieDataDelegate(string moviename)
            : base("Project.RetrieveMovie")
        {
            this.moviename = moviename;
        }

        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Movie>();

            while (reader.Read())
            {
                movies.Add(new Movie(
                    reader.GetInt32("MovieId"),
                    reader.GetString("Name"),
                    reader.GetString("Movie"),
                    reader.GetDecimal("Rating"),
                    reader.GetString("Director")));
            }

            return movies;
        }
    }
}
