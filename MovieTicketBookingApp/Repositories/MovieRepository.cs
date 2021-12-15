using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;

namespace MovieTicketBookingApp.Repositories {
    public class MovieRepository : RepositoryBase<Movie> {
        public MovieRepository(MovieBookingContext context) : base(context)
        {
        }
    }
}
