using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketBookingApp.Models {
    public class Show {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [ForeignKey("TheatreId")]
        public int TheatreId { get; set; }
        public Theatre Theatre { get; set; }

        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public TimeSpan Timing { get; set; }
        //public IList<Seat> AvailableSeats { get; set; }
        //public IList<Seat> BookedSeats { get; set; }
        public int TotalSeats { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}