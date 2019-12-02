using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates;

namespace MovieProject
{
    public class SqlHighestRatedMovieRepository : IHighestRatedMovieRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlHighestRatedMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Report1Object> RatingOverTime(string start, string end)
        {
            var d = new RatingOverTimeDataDelegate(start, end);
            return executor.ExecuteReader(d);
        }

    }
}
