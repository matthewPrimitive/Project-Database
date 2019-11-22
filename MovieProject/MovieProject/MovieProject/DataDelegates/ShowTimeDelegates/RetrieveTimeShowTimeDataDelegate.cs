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
    public class RetrieveTimeShowTimeDataDelegate : DataReaderDelegate<ShowTime>
    {
        private readonly string time;

        public RetrieveTimeShowTimeDataDelegate(string time)
            : base("Movie.RetrieveTimeShowTime")
        {
            this.time = time;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Time", time);
        }

        public override ShowTime Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(time.ToString());

            return new ShowTime(reader.GetInt32("ShowTimeId"),
                reader.GetInt32("MovieId"),
                time,
                reader.GetString("Date"),
                reader.GetDecimal("Price"));
        }
    }
}
