using Microsoft.AspNetCore.Mvc;

namespace MoviesTickets.Controllers
{
    public class ProducersController : Controller
    {
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
