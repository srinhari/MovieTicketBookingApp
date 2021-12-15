using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;

namespace MovieTicketBookingApp.Repositories {
    public class BookingRepository : RepositoryBase<Booking> {
        public BookingRepository(MovieBookingContext context) : base(context)
        {
        }
    }
}
