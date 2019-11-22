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
    public class FetchShowTimeDataDelegate : DataReaderDelegate<ShowTime>
    {
        private readonly int showtimeId;

        public FetchShowTimeDataDelegate(int showtimeId)
            : base("Movie.FetchShowTime")
        {
            this.showtimeId = showtimeId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShowTimeId", showtimeId);
        }

        public override ShowTime Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(showtimeId.ToString());

            return new ShowTime(showtimeId,
                reader.GetInt32("MovieId"),
                reader.GetString("Time"),
                reader.GetString("Date"),
                reader.GetDecimal("Price"));
        }
    }
}
