using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using System.Data.SqlClient;

namespace MovieProject.DataDelegates.TicketDelegates
{
    public class CreateTicketDataDelegate : NonQueryDataDelegate<Ticket>
    {
        public readonly int viewerId;
        public readonly int showtimeId;

        public CreateTicketDataDelegate(int viewerId, int showtimeId)
            : base("Project.CreateTicket")
        {
            this.viewerId = viewerId;
            this.showtimeId = showtimeId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ViewerId", viewerId);
            command.Parameters.AddWithValue("ShowTimeId", showtimeId);

            var p = command.Parameters.Add("TicketId", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
        }

        public override Ticket Translate(SqlCommand command)
        {
            return new Ticket((int)command.Parameters["TicketId"].Value, viewerId, showtimeId);
        }
    }
}
