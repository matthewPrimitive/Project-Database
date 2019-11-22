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
    public class RetrieveDateShowTimeDataDelegate : DataReaderDelegate<ShowTime>
    {
        private readonly string date;

        public RetrieveDateShowTimeDataDelegate(string date)
            : base("Project.RetrieveDateShowTime")
        {
            this.date = date;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Date", date);
        }

        public override ShowTime Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(date.ToString());

            return new ShowTime(reader.GetInt32("ShowTimeId"),
                reader.GetInt32("MovieId"),
                reader.GetString("Time"),
                date,
                reader.GetDecimal("Price"));
        }
    }
}
