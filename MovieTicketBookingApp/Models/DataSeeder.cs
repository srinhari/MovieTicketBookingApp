using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBookingApp.Models {
    public class DataSeeder {

        private readonly MovieBookingContext _context;

        public DataSeeder(MovieBookingContext context) {
            _context = context;
        }

        public void Seed() {

            _context.Database.EnsureCreated();
            if (!_context.Movies.Any()) {
                _context.Movies.AddRange(
                    new Movie {
                        Id = 1,
                        Name = "Movie1",
                        Description = "Movie1",
                        Genre = "abc"
                    },
                    new Movie {
                        Id = 2,
                        Name = "Movie2",
                        Description = "Movie2",
                        Genre = "abs"
                    }, new Movie {
                        Id = 3,
                        Name = "Movie3",
                        Description = "Movie3",
                        Genre = "def"
                    });
            }

            if (!_context.Theatres.Any()) {
                _context.Theatres.AddRange(
                    new Theatre() {
                        Id = 1,
                        Name = "Theatre1",
                        City = "Mumbai"
                    },
                    new Theatre {
                        Id = 2,
                        Name = "Theatre2",
                        City = "Chennai"
                    },
                    new Theatre {
                        Id = 3,
                        Name = "Theatre3",
                        City = "Hyderabad"
                    },
                    new Theatre() {
                        Id = 4,
                        Name = "Theatre4",
                        City = "Mumbai"
                    },
                    new Theatre {
                        Id = 5,
                        Name = "Theatre5",
                        City = "Chennai"
                    },
                    new Theatre {
                        Id = 6,
                        Name = "Theatre6",
                        City = "Hyderabad"
                    });
            }

            if (!_context.Shows.Any()) {
                _context.Shows.AddRange(new Show() {
                    Id = 1,
                    MovieId = 1,
                    TheatreId = 1,
                    Timing = new TimeSpan(3, 0, 0),
                    TotalSeats = 300
                },
                    new Show {
                        Id = 2,
                        MovieId = 1,
                        TheatreId = 2,
                        Timing = new TimeSpan(3, 0, 0),
                        TotalSeats = 400
                    },
                    new Show {
                        Id = 3,
                        MovieId = 2,
                        TheatreId = 1,
                        Timing = new TimeSpan(2, 0, 0),
                        TotalSeats = 400
                    },
                    new Show() {
                        Id = 4,
                        MovieId = 3,
                        TheatreId = 3,
                        Timing = new TimeSpan(3, 0, 0),
                        TotalSeats = 600
                    },
                    new Show {
                        Id = 5,
                        MovieId = 3,
                        TheatreId = 4,
                        Timing = new TimeSpan(2, 0, 0),
                        TotalSeats = 400
                    },
                    new Show {
                        Id = 6,
                        MovieId = 2,
                        TheatreId = 6,
                        Timing = new TimeSpan(3, 0, 0),
                        TotalSeats = 300
                    });
            }

            _context.SaveChanges();
        }
    }
}
