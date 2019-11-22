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
    public class FetchActorOnNameDataDelegate : DataReaderDelegate<Actor>
    {
        private readonly string name;

        public FetchActorOnNameDataDelegate(string name)
            : base("Movie.FetchActor")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override Actor Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(name.ToString());

            return new Actor(reader.GetInt32("ActorId"), name);
        }
    }
}
