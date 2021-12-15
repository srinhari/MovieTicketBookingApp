using MovieTicketBookingApp.Models;
using MovieTicketBookingApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MovieTicketBookingApp.Services {
    public class MovieBookingService : IBookingService {

        private IRepository<Movie> _movieRepository;

        public IRepository<Movie> MovieRepository
        {
            get
            {
                if (_movieRepository == null)
                {
                    _movieRepository = new MovieRepository(_context);
                }

                return _movieRepository;
            }
        }
        private IRepository<Show> _showRepository;
        public IRepository<Show> ShowRepository {
            get {
                if (_showRepository == null) {
                    _showRepository = new ShowRepository(_context);
                }

                return _showRepository;
            }
        }
        private  IRepository<Theatre> _theatreRepository;
        public IRepository<Theatre> TheatreRepository {
            get {
                if (_theatreRepository == null) {
                    _theatreRepository = new TheatreRepository(_context);
                }

                return _theatreRepository;
            }
        }

        private  IRepository<Seat> _seatRepository;
        public IRepository<Seat> SeatRepository {
            get {
                if (_seatRepository == null) {
                    _seatRepository = new SeatRepository(_context);
                }

                return _seatRepository;
            }
        }
        private  IRepository<Ticket> _ticketRepository;
        public IRepository<Ticket> TicketRepository {
            get {
                if (_ticketRepository == null) {
                    _ticketRepository = new TicketRepository(_context);
                }

                return _ticketRepository;
            }
        }
        private  IRepository<Booking> _bookingRepository;
        public IRepository<Booking> BookingRepository {
            get {
                if (_bookingRepository == null) {
                    _bookingRepository = new BookingRepository(_context);
                }

                return _bookingRepository;
            }
        }
        private readonly MovieBookingContext _context;

        public MovieBookingService(MovieBookingContext context)
        {
            _context = context;
        }
        public IList<string> GetCities() {
            //return new List<string> { "Mumbai", "Delhi", "Bangalore", "Chennai", "Hyderabad" };
            var cities = TheatreRepository.All().Select(theater => theater.City).Distinct().ToList();
            return cities;
        }

        public IList<Movie> GetMovies(string city) {
            //find all THEATRE where theatre.city is matching with city
            //get theatre id and find the SHOWS with the theatre id and find all MOVIES matching the Show.MovieId
            //_theatreRepository.Find(t => t.City == city)
            
            var movs = (from show in ShowRepository.All()
                    //        join movie in MovieRepository.All()
                    //on show.Movie.Id equals movie.Id
                    where show.Theatre.City.Equals(city)
                            select show.Movie).ToList();

            return movs;
        }

        public IList<Show> GetShows(string movie, string city)
        {
            var shows = (from show in ShowRepository.All()
                where show.Movie.Name.ToLower().Equals(movie.ToLower())
                where show.Theatre.City.Equals(city)
                select show).ToList();
            return shows;
        }

        public Ticket BookTicket(Show show, int numSeats) {
            return new Ticket();
        }
    }

    public interface IBookingService
    {
        public IList<string> GetCities();

        public IList<Movie> GetMovies(string city);

        public IList<Show> GetShows(string movie, string city);

        public Ticket BookTicket(Show show, int numSeats);

        public IRepository<Theatre> TheatreRepository { get; }
    }
}
