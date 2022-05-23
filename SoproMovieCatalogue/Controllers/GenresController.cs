using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoproMovieCatalogue.Data;

namespace SoproMovieCatalogue.Controllers
{
    public class GenresController : Controller
    {
        private readonly AppDbContext _context;

        public GenresController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allGenres = await _context.Genres.ToListAsync();
            return View(allGenres);
        }
    }
}
