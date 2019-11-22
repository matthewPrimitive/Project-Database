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
    public class RetrieveViewerTicketDataDelegate : DataReaderDelegate<IReadOnlyList<Ticket>>
    {
        private readonly int viewerId;

        public RetrieveViewerTicketDataDelegate(int viewerId)
            : base("Project.RetrieveViewerTicket")
        {
            this.viewerId = viewerId;
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
