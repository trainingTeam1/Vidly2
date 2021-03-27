using System;
using System.Linq;
using System.Web.Http;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //POST /api/newRental
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);
            if (customer == null)
                return BadRequest("CustomerId is not valid");

            if (newRental.MovieIds.Count == 0)
                return BadRequest("No movies selected");

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more movies not found");

            foreach (var movie in movies)
            {
                if (movie.NumbersAvailable == 0)
                    return BadRequest("Movie is not available");

                var rental = new Rental()
                {
                    Movie = movie,
                    Customer = customer,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);

                movie.NumbersAvailable -= 1;
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}