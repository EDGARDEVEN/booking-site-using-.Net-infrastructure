using Microsoft.AspNetCore.Mvc;
using YourProject.Models;
using YourProject.Data;

namespace booking.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Display list of bookings
            var bookings = _context.Bookings.ToList();
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
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // Add other action methods as needed (e.g., Edit, Delete)
    }
}
