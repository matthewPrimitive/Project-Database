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
    public class RetrieveTimeShowTimeDataDelegate : DataReaderDelegate<IReadOnlyList<ShowTime>>
    {
        private readonly string time;

        public RetrieveTimeShowTimeDataDelegate(string time)
            : base("Project.RetrieveTimeShowTime")
        {
            this.time = time;
        }

        public override IReadOnlyList<ShowTime> Translate(SqlCommand command, IDataRowReader reader)
        {
            var showtimes = new List<ShowTime>();

            while (reader.Read())
            {
                showtimes.Add(new ShowTime(
                    reader.GetInt32("ShowTimeId"),
                    reader.GetInt32("MovieId"),
                    time,
                    reader.GetString("Date"),
                    reader.GetDecimal("Price")));
            }
            return showtimes;
        }
    }
}
