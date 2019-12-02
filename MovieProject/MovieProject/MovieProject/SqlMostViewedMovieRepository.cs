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
    public class SqlMostViewedMovieRepository : IMostViewedMovieRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMostViewedMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Report2Object> MostViewed(string start, string end)
        {
            var d = new MostViewedDataDelegate(start, end);
            return executor.ExecuteReader(d);
        }

    }
}
