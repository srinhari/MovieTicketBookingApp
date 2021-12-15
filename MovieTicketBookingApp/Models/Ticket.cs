using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketBookingApp.Models
{
    public class Ticket {
        public int Id { get; set; }

        [ForeignKey("ShowId")]
        public int ShowId { get; set; }
        public Show Show { get; set; }
        //public List<Seat> Seats { get; set; }
        public int Quantity { get; }

        public ICollection<Booking> Bookings { get; set; }
        
    }
}