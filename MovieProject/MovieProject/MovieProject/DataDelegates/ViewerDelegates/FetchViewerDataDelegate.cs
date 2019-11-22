using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using System.Data.SqlClient;

namespace MovieProject.DataDelegates.ViewerDelegates
{
    public class FetchViewerDataDelegate : DataReaderDelegate<Viewer>
    {
        private readonly int viewerId;

        public FetchViewerDataDelegate(int viewerId)
            : base("Project.FetchViewer")
        {
            this.viewerId = viewerId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ViewerId", viewerId);
        }

        public override Viewer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(viewerId.ToString());

            return new Viewer(viewerId,
                reader.GetString("Gender"),
                reader.GetString("Name"),
                reader.GetString("Email"),
                reader.GetString("BirthDate"),
                reader.GetString("Username"));
        }
    }
}
