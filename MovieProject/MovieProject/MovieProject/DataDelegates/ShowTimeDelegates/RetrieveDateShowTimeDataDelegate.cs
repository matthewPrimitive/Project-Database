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
    public class RetrieveDateShowTimeDataDelegate : DataReaderDelegate<IReadOnlyList<ShowTime>>
    {
        private readonly string date;

        public RetrieveDateShowTimeDataDelegate(string date)
            : base("Project.RetrieveDateShowTime")
        {
            this.date = date;
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
                    date,
                    reader.GetDecimal("Price")));
            }
            return showtimes;
        }
    }
}
