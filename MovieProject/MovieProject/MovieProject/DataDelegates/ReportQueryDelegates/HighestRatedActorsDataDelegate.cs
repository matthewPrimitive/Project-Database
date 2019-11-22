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
    public class HighestRatedActorsDataDelegate : DataReaderDelegate<IReadOnlyList<Report4Object>>
    {
        public HighestRatedActorsDataDelegate()
            : base("Project.HighestRatedActors")
        {
        }

        public override IReadOnlyList<Report4Object> Translate(SqlCommand command, IDataRowReader reader)
        {
            var actors = new List<Report4Object>();

            while (reader.Read())
            {
                actors.Add(new Report4Object(
                    reader.GetString("Name"),
                    reader.GetDecimal("OverallRating")));
            }

            return actors;
        }
    }
}
