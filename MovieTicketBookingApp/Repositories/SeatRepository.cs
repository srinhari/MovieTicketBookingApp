using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;

namespace MovieTicketBookingApp.Repositories {
    public class SeatRepository : RepositoryBase<Seat> {
        public SeatRepository(MovieBookingContext context) : base(context)
        {
        }
    }
}
