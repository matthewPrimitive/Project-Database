using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using System.Data.SqlClient;

namespace MovieProject.DataDelegates.ActorDelegates
{
    public class FetchActorOnMovieDataDelegate : DataReaderDelegate<IReadOnlyList<Actor>>
    {
        private readonly int movieId;

        public FetchActorOnMovieDataDelegate(int movieId)
            : base("Project.FetchActorOnMovie")
        {
            this.movieId = movieId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MovieId", movieId);            
        }

        public override IReadOnlyList<Actor> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Actor> actor = new List<Actor>();

            while (reader.Read())
            {
                actor.Add(new Actor(
                    reader.GetInt32("ActorId"),
                    reader.GetString("Name")));
            }
            return actor;
        }
    }
}
