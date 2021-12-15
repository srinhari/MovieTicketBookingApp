using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieTicketBookingApp.Models;
using MovieTicketBookingApp.Repositories;
using MovieTicketBookingApp.Services;

namespace MovieTicketBookingAppTest {

    [TestClass]
    public class BookingServiceTests {

        [TestMethod]
        public void GetAllCities_NoTheatres_ReturnEmpty()
        {
            var options = new DbContextOptionsBuilder<MovieBookingContext>()
                .UseInMemoryDatabase("MovieBookingInMemoryDB").Options;

            using (var context = new MovieBookingContext(options))
            {
                context.SaveChanges();
                var bookingService = new MovieBookingService(context);
                Assert.AreEqual(0, bookingService.GetCities().Count);
            }
        }

        [TestMethod]
        public void GetAllCities_WithTheatreData_ReturnCities()
        {
            var options = new DbContextOptionsBuilder<MovieBookingContext>()
                .UseInMemoryDatabase("MovieBookingInMemoryDB").Options;

            using (var context = new MovieBookingContext(options))
            {
                var theaterRepository = new TheatreRepository(context);
                theaterRepository.Add(new Theatre() {City = "Mumbai", Id = 1, Name = "MyTheatre"});
                theaterRepository.Add(new Theatre() { City = "Chennai", Id = 2, Name = "MyTheatre" });
                theaterRepository.Add(new Theatre() { City = "Hyderabad", Id = 3, Name = "MyTheatre" });
                theaterRepository.Add(new Theatre() { City = "Hyderabad", Id = 4, Name = "MyTheatre" });
                context.SaveChanges();

                var bookingService = new MovieBookingService(context);
                Assert.AreEqual(3, bookingService.GetCities().Count);

                CollectionAssert.AreEquivalent(new List<string> {"Mumbai", "Hyderabad", "Chennai"}, bookingService.GetCities().ToList());
            }
        }
    }
}
