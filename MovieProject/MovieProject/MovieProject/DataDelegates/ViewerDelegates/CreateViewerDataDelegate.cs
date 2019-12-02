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
    public class CreateViewerDataDelegate : NonQueryDataDelegate<Viewer>
    {
        public readonly string name;
        public readonly string gender;
        public readonly string email;
        public readonly string birthdate;
        public readonly string username;

        public CreateViewerDataDelegate(string name, string gender, string email, string birthdate, string username)
            : base("Project.CreateViewer")
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
            this.birthdate = birthdate;
            this.username = username;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Gender", gender);
            command.Parameters.AddWithValue("Email", email);
            command.Parameters.AddWithValue("BirthDate", birthdate);
            command.Parameters.AddWithValue("Username", username);

            var p = command.Parameters.Add("ViewerId", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }

        public override Viewer Translate(SqlCommand command)
        {
            return new Viewer((int)command.Parameters["ViewerId"].Value, name, gender, email, birthdate, username);
        }
    }
}
