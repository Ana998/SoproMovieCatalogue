using Microsoft.EntityFrameworkCore;
using SoproMovieCatalogue.Models;

namespace SoproMovieCatalogue.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;

        public MoviesService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var result = await _context.Movies.ToListAsync();
            return result;
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie update(int id, Movie newMovie)
        {
            throw new NotImplementedException();
        }
    }
}
