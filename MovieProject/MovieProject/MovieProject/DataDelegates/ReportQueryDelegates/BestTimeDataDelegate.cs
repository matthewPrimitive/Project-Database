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
    public class BestTimeDataDelegate : DataReaderDelegate<IReadOnlyList<Report3Object>>
    {
        public BestTimeDataDelegate()
            : base("Project.BestTime")
        {
        }

        public override IReadOnlyList<Report3Object> Translate(SqlCommand command, IDataRowReader reader)
        {
            var times = new List<Report3Object>();

            while (reader.Read())
            {
                times.Add(new Report3Object(
                    reader.GetString("Time"),
                    reader.GetString("DayOfTheWeek"), //Potentially need something else, not sure how this lookup works
                    reader.GetInt32("NumberOfViewers")));
            }

            return times;
        }
    }
}
