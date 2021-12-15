using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;

namespace MovieTicketBookingApp.Repositories {
    public class TheatreRepository : RepositoryBase<Theatre> {
        public TheatreRepository(MovieBookingContext context) : base(context)
        {
        }
    }
}
