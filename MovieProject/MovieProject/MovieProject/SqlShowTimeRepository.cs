using System;
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

        public ShowTime FetchShowTime(int showTimeId)
        {
            var d = new FetchShowTimeDataDelegate(showTimeId);
            return executor.ExecuteReader(d);
        }

        public ShowTime RetrieveMovieShowTime(int movieId)
        {
            var d = new RetrieveMovieShowTimeDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }

        public ShowTime RetrieveTimeShowTime(string time)
        {
            var d = new RetrieveMovieShowTimeDataDelegate(time);
            return executor.ExecuteReader(d);
        }

        public ShowTime RetrieveDateShowTime(string date)
        {
            var d = new RetrieveMovieShowTimeDataDelegate(date);
            return executor.ExecuteReader(d);
        }
    }
}
