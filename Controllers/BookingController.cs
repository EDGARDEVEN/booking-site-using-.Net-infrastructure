using Microsoft.AspNetCore.Mvc;
using booking.Models;
using booking.Data;
using booking.Services;
using Microsoft.EntityFrameworkCore;

namespace booking.Controllers
{
    public class BookingController : Controller
    {
        private readonly AppDbContext dbContext;

        public BookingController(AppDbContext dbContext )
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            // Display list of bookings
            var bookings = dbContext.Bookings.ToList();
            return View(bookings);
        }

        public IActionResult Create()
        {
            // Display booking form
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            // Process booking form submission
            if (ModelState.IsValid)
            {
                dbContext.Bookings.Add(booking);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // Add other action methods as needed (e.g., Edit, Delete)
    }
}
