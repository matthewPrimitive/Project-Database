using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates.ShowTimeDelegates;
namespace MovieProject
{
    public class SqlShowTimeRepository : IShowTimeRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlShowTimeRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        /*
        public IReadOnlyList<ShowTime> FetchShowTime()
        {
            var d = new FetchShowTimesDataDelegate();
            return executor.ExecuteReader(d);
        }
        */
        public ShowTime FetchShowTime(int showTimeId)
        {
            var d = new FetchShowTimeDataDelegate(showTimeId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<ShowTime> RetrieveMovieShowTime(int movieId)
        {
            var d = new RetrieveMovieShowTimeDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<ShowTime> RetrieveTimeShowTime(string time)
        {
            var d = new RetrieveTimeShowTimeDataDelegate(time);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<ShowTime> RetrieveDateShowTime(string date)
        {
            var d = new RetrieveDateShowTimeDataDelegate(date);
            return executor.ExecuteReader(d);
        }
    }
}
