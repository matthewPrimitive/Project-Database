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
    public class RetrieveViewerOnGenderDataDelegate : DataReaderDelegate<Viewer>
    {
        private readonly string gender;

        public RetrieveViewerOnGenderDataDelegate(string gender)
            : base("Project.RetrieveViewerOnGender")
        {
            this.gender = gender;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Gender", gender);
        }

        public override Viewer Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(gender.ToString());

            return new Viewer(reader.GetInt32("ViewerId"),
                gender,
                reader.GetString("Name"),
                reader.GetString("Email"),
                reader.GetString("BirthDate"),
                reader.GetString("Username"));
        }
    }
}
