using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using System.Data.SqlClient;

namespace MovieProject.DataDelegates.ShowTimeDelegates
{
    public class RetrieveMovieShowTimeDataDelegate : DataReaderDelegate<IReadOnlyList<ShowTime>>
    {
        private readonly int movieId;

        public RetrieveMovieShowTimeDataDelegate(int movieId)
            : base("Project.RetrieveMovieShowTime")
        {
            this.movieId = movieId;
        }

        public override IReadOnlyList<ShowTime> Translate(SqlCommand command, IDataRowReader reader)
        {
            var showtimes = new List<ShowTime>();

            while (reader.Read())
            {
                showtimes.Add(new ShowTime(
                    reader.GetInt32("ShowTimeId"),
                    movieId,
                    reader.GetString("Time"),
                    reader.GetString("Date"),
                    reader.GetDecimal("Price")));
            }
            return showtimes;
        }
    }
}
