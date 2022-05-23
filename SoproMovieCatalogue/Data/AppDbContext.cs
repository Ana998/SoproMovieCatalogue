using Microsoft.EntityFrameworkCore;
using SoproMovieCatalogue.Models;

namespace SoproMovieCatalogue.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            modelBuilder.Entity<Genre_Movie>().HasKey(gm => new
            {
                gm.GenreId,
                gm.MovieId
            });

            modelBuilder.Entity<Genre_Movie>().HasOne(m => m.Movie).WithMany(gm => gm.Genres_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Genre_Movie>().HasOne(m => m.Genre).WithMany(gm => gm.Genres_Movies).HasForeignKey(m => m.GenreId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Genre_Movie> Genres_Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
