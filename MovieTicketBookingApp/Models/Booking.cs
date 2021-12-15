using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBookingApp.Models {
    public class Booking {
        public int Id { get; set; }

        [ForeignKey("TicketId")]
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        [ForeignKey("SeatId")]
        public int SeatId { get; set; }

        public Seat Seat { get; set; }



    }
}
