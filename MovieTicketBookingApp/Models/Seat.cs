using System.Collections;
using System.Collections.Generic;

namespace MovieTicketBookingApp.Models
{
    public class Seat
    {
        public int Id { get; set; }

        public ICollection<Booking> Bookings { get; set; }

        //public string SeatLabel { get; set; }
    }
}