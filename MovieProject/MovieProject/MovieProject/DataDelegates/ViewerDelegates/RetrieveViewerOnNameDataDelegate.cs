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
    public class RetrieveViewerOnNameDataDelegate : DataReaderDelegate<IReadOnlyList<Viewer>>
    {
        private readonly string name;

        public RetrieveViewerOnNameDataDelegate(string name)
            : base("Project.RetrieveViewerOnName")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
        }

        public override IReadOnlyList<Viewer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var viewers = new List<Viewer>();

            while (reader.Read())
            {
                viewers.Add(new Viewer(
                    reader.GetInt32("ViewerId"),
                    reader.GetString("Gender"),
                    name,
                    reader.GetString("Email"),
                    reader.GetString("BirthDate"),
                    reader.GetString("Username")));
            }
            return viewers;
        }
    }
}
