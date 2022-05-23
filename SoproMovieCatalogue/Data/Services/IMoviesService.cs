using SoproMovieCatalogue.Models;

namespace SoproMovieCatalogue.Data.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        Movie update(int id, Movie newMovie);
        void Delete(int id);

    }
}
