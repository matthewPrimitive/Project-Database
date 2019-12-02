using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates.ActorDelegates;


namespace MovieProject
{
    public class SqlActorRepository : IActorRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlActorRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Actor FetchActor(int actorId)
        {
            var d = new FetchActorDataDelegate(actorId);
            return executor.ExecuteReader(d);
        }

        public Actor FetchActorOnName(string name)
        {
            var d = new FetchActorOnNameDataDelegate(name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Actor> FetchActorOnMovie(int movieId)
        {
            var d = new FetchActorOnMovieDataDelegate(movieId);
            return executor.ExecuteReader(d);
        }
    }
}
