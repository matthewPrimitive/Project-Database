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
    public class RatingOverTimeDataDelegate : DataReaderDelegate<IReadOnlyList<Report1Object>>
    {
        private readonly string startdate;
        private readonly string enddate;

        public RatingOverTimeDataDelegate(string start, string end)
            : base("Project.RatingOverTime")
        {
            startdate = start;
            enddate = end;
        }

        public override IReadOnlyList<Report1Object> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Report1Object>();

            while (reader.Read())
            {
                movies.Add(new Report1Object(
                    reader.GetString("Name"),
                    reader.GetDecimal("Rating")));
            }

            return movies;
        }
    }
}
