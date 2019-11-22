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
    public class FetchActorDataDelegate : DataReaderDelegate<Actor>
    {
        private readonly int actorId;

        public FetchActorDataDelegate(int actorId)
            : base("Project.FetchActor")
        {
            this.actorId = actorId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ActorId", actorId);
        }

        public override Actor Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(actorId.ToString());

            return new Actor(actorId, reader.GetString("Name"));
        }
    }
}
