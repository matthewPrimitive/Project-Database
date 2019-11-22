using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Models
{
    public class Ticket
    {
        public int TicketId { get; }

        public int ViewerId { get; }

        public int ShowTimeId { get; }

        public Ticket (int ticketid, int viewerid, int showtimeid)
        {
            TicketId = ticketid;
            ViewerId = viewerid;
            ShowTimeId = showtimeid;
        }
    }
}
