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
    public class RetrieveShowTimeTicketDataDelegate : DataReaderDelegate<IReadOnlyList<Ticket>>
    {
        private readonly int showtimeId;

        public RetrieveShowTimeTicketDataDelegate(int showtimeId)
            : base("Project.RetrieveShowTimeTicket")
        {
            this.showtimeId = showtimeId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ShowTimeId", showtimeId);
        }

        public override IReadOnlyList<Ticket> Translate(SqlCommand command, IDataRowReader reader)
        {
            var tickets = new List<Ticket>();

            while (reader.Read())
            {
                tickets.Add(new Ticket(
                    reader.GetInt32("TicketId"),
                    reader.GetInt32("ViewerId"),
                    reader.GetInt32("ShowTimeId")));
            }
            return tickets;
        }
    }
}
