using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using System.Data.SqlClient;


namespace MovieProject.DataDelegates.MovieDelegates
{
    public class RetrieveDirectorDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
    {
        private readonly string director;

        public RetrieveDirectorDataDelegate(string director)
            : base("Project.RetrieveDirector")
        {
            this.director = director;
        }

        public override IReadOnlyList<Movie> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Movie>();

            while(reader.Read())
            {
                movies.Add(new Movie(
                    reader.GetInt32("MovieId"),
                    reader.GetString("Name"),
                    reader.GetString("Genre"),
                    reader.GetDecimal("Rating"),
                    reader.GetString("Director")));
            }

            return movies;
        }
    }
}
