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
    public class FetchTicketDataDelegate : DataReaderDelegate<Ticket>
    {
        private readonly int ticketId;

        public FetchTicketDataDelegate(int ticketId)
            : base("Movie.FetchTicket")
        {
            this.ticketId = ticketId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("TicketId", ticketId);
        }

        public override Ticket Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ticketId.ToString());

            return new Ticket(ticketId, reader.GetInt32("ViewerId"), reader.GetInt32("ShowTimeId"));
        }
    }
}
