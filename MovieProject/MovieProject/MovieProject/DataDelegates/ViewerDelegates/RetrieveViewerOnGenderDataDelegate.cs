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
    public class RetrieveViewerOnGenderDataDelegate : DataReaderDelegate<IReadOnlyList<Viewer>>
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

        public override IReadOnlyList<Viewer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var viewers = new List<Viewer>();

            while (reader.Read())
            {
                viewers.Add(new Viewer(
                    reader.GetInt32("ViewerId"),
                    gender,
                    reader.GetString("Name"),
                    reader.GetString("Email"),
                    reader.GetString("BirthDate"),
                    reader.GetString("Username")));
            }
            return viewers;
        }
    }
}
