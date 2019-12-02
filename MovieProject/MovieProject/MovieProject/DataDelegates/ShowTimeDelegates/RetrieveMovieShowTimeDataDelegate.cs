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
        public readonly int movieId;

        public RetrieveMovieShowTimeDataDelegate(int movieId)
            : base("Project.RetrieveMovieShowTime")
        {
            this.movieId = movieId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieId", movieId);
        }

        public override IReadOnlyList<ShowTime> Translate(SqlCommand command, IDataRowReader reader)
        {
            var showtimes = new List<ShowTime>();
            

            while (reader.Read())
            {
                showtimes.Add(new ShowTime(
                    reader.GetInt32("ShowTimeId"),
                    reader.GetInt32("MovieId"),
                    reader.GetString("Time"),
                    reader.GetString("Date"),
                    reader.GetDecimal("Price")));
            }
            return showtimes;
        }
    }
}
