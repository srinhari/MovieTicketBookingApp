using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieTicketBookingApp.Models {
    public class MovieBookingContext : DbContext {
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public MovieBookingContext(DbContextOptions<MovieBookingContext> options) : 
            base(options) {
            //Database.EnsureCreated();
        }  

    }
}
