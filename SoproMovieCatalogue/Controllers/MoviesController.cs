using Microsoft.AspNetCore.Mvc;
using SoproMovieCatalogue.Data.Services;
using SoproMovieCatalogue.Models;

namespace SoproMovieCatalogue.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            //var allMovies = await _service.Movies.Include(n => n.Genres_Movies).ToListAsync();
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Actor,Producer,Director,Genre")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            _service.Add(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}
