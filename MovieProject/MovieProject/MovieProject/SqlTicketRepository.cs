using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MovieProject.Models;
using MovieProject.DataDelegates.TicketDelegates;


namespace MovieProject
{
    public class SqlTicketRepository : ITicketRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlTicketRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Ticket CreateTicket(int viewerId, int showTimeId, string purchasedOn)
        {
            var d = new CreateTicketDataDelegate(viewerId, showTimeId, purchasedOn);
            return executor.ExecuteNonQuery(d);
        }

        public Ticket FetchTicket(int ticketId)
        {
            var d = new FetchTicketDataDelegate(ticketId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Ticket> RetrieveViewerTicket(int viewerId)
        {
            var d = new RetrieveViewerTicketDataDelegate(viewerId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Ticket> RetrieveShowTimeTicket(int showTimeId)
        {
            var d = new RetrieveShowTimeTicketDataDelegate(showTimeId);
            return executor.ExecuteReader(d);
        }
    }
}
