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
    public class MostViewedDataDelegate : DataReaderDelegate<IReadOnlyList<Report2Object>>
    {
        private readonly string startDate;
        private readonly string endDate;

        public MostViewedDataDelegate(string start, string end)
            : base("Project.MostViewed")
        {
            startDate = start;
            endDate = end;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("StartDate", startDate);
            command.Parameters.AddWithValue("EndDate", endDate);       
        }

        public override IReadOnlyList<Report2Object> Translate(SqlCommand command, IDataRowReader reader)
        {
            var movies = new List<Report2Object>();

            while (reader.Read())
            {
                movies.Add(new Report2Object(
                    reader.GetString("Name"),
                    reader.GetInt32("NumberOfViewers")));
            }
            return movies;
        }
    }
}
