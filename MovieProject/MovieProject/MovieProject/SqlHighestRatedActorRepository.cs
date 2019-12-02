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
    public class SqlHighestRatedActorRepository : IHighestRatedActorRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlHighestRatedActorRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<Report4Object> HighestRatedActor()
        {
            return executor.ExecuteReader(new HighestRatedActorsDataDelegate());
        }
    }
}
