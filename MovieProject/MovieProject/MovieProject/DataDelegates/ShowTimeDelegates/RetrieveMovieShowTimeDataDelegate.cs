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
    public class RetrieveMovieShowTimeDataDelegate : DataReaderDelegate<ShowTime>
    {
        private readonly int movieId;

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

        public override ShowTime Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(movieId.ToString());

            return new ShowTime(reader.GetInt32("ShowTimeId"),
                movieId,
                reader.GetString("Time"),
                reader.GetString("Date"),
                reader.GetDecimal("Price"));
        }
    }
}
