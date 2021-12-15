using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicketBookingApp.Models;
using MovieTicketBookingApp.Services;

namespace MovieTicketBookingApp.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class MovieBookingController : ControllerBase
    {
        private readonly IBookingService service;

        public MovieBookingController(IBookingService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("Cities")]
        public IActionResult Cities()
        {
            return Ok(service.GetCities());
        }
        
        [Route("Movies/{city}")]
        public IActionResult Movies(string city) {
            return Ok(service.GetMovies(city));
        }
        
        [Route("Shows/{movieName}/{city}")]
        public IActionResult GetShows(string movieName, string city) {
            return Ok(service.GetShows(movieName, city));
        }

        [Route("Book")]
        public IActionResult BookTicket([FromBody] Show show, [FromQuery] int numSeats) {
            return Ok(service.BookTicket(show, numSeats));
        }
    }
}
