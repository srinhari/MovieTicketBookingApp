using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;

namespace MovieTicketBookingApp.Repositories {
    public class ShowRepository : RepositoryBase<Show> {
        public ShowRepository(MovieBookingContext context) : base(context)
        {
        }
    }
}
