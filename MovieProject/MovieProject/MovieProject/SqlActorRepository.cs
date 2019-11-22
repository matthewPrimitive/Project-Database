using System;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates.ActorDelegates;
namespace MovieProject
{
    public class SqlActorRepository : IActorRepository
    {
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
    }
}
