using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates;
using MovieProject.DataDelegates.ActorDelegates;

namespace MovieProject
{
    public class SqlBestTimeRepository : IBestTimeRepository        
    {
        private readonly SqlCommandExecutor executor;

        public SqlBestTimeRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Report3Object> BestTime()
        {
            return executor.ExecuteReader(new BestTimeDataDelegate());
        }
    }
}
