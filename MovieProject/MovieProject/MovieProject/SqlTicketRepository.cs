using System;
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

        public Ticket FetchTicket(int ticketId)
        {
            var d = new FetchTicketDataDelegate(ticketId);
            return executor.ExecuteReader(d);
        }

        public Ticket RetrieveViewerTicket(int viewerId)
        {
            var d = new RetrieveViewerTicketDataDelegate(viewerId);
            return executor.ExecuteReader(d);
        }

        public Ticket RetrieveShowTimeTicket(int showTimeId)
        {
            var d = new RetrieveShowTimeTicketDataDelegate(showTimeId);
            return executor.ExecuteReader(d);
        }
    }
}
