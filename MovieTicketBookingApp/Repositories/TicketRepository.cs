using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;

namespace MovieTicketBookingApp.Repositories {
    public class TicketRepository : RepositoryBase<Ticket> {
        public TicketRepository(MovieBookingContext context) : base(context)
        {
        }
    }
}
