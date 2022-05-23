using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoproMovieCatalogue.Data;

namespace SoproMovieCatalogue.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly AppDbContext _context;

        public DirectorsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allDirectors = await _context.Directors.ToListAsync();
            return View(allDirectors);
        }
    }
}
