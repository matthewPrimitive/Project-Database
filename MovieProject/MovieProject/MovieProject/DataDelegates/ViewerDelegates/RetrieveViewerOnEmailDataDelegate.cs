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
    public class RetrieveViewerOnEmailDataDelegate : DataReaderDelegate<Viewer>
    {
        private readonly string email;

        public RetrieveViewerOnEmailDataDelegate(string email)
            : base("Project.RetrieveViewerOnEmail")
        {
            this.email = email;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Email", email);
        }

        public override Viewer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(email.ToString());

            return new Viewer(reader.GetInt32("ViewerId"),
                reader.GetString("Gender"),
                reader.GetString("Name"),
                email,
                reader.GetString("BirthDate"),
                reader.GetString("Username"));
        }
    }
}
