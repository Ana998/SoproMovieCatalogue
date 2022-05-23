using SoproMovieCatalogue.Models;

namespace SoproMovieCatalogue.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Producer 1",
                            Bio = "Biography of first producer"
                        },
                        new Producer()
                        {
                            Name = "Producer 2",
                            Bio = "Biography of second producer"
                        },
                        new Producer()
                        {
                            Name = "Producer 3",
                            Bio = "Biography of third producer"
                        },
                        new Producer()
                        {
                            Name = "Producer 4",
                            Bio = "Biography of fourth producer"
                        },
                        new Producer()
                        {
                            Name = "Producer 5",
                            Bio = "Biography of fifth producer"
                        },

                    });
                    context.SaveChanges();
                }
                //Directors
                if (!context.Directors.Any())
                {
                    context.Directors.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            Name = "Director 1"
                        },
                        new Director()
                        {
                            Name = "Director 2"
                        },
                        new Director()
                        {
                            Name = "Director 3"
                        },
                        new Director()
                        {
                            Name = "Director 4"
                        },
                        new Director()
                        {
                            Name = "Director 5"
                        },
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Id = 1,
                            Name = "Movie 1",
                            ProducerId = 1,
                            DirectorId = 1,


                        },
                        new Movie()
                        {
                            Id = 2,
                            Name = "Movie 2",
                            ProducerId = 2,
                            DirectorId = 2
                        },
                        new Movie()
                        {
                            Id = 3,
                            Name = "Movie 3",
                            ProducerId = 3,
                            DirectorId = 3
                        },
                        new Movie()
                        {
                            Id = 4,
                            Name = "Movie 4",
                            ProducerId = 4,
                            DirectorId = 4
                        },
                        new Movie()
                        {
                            Id = 5,
                            Name = "Movie 5",
                            ProducerId = 5,
                            DirectorId = 5
                        },
                    });
                    context.SaveChanges();
                }
                //Genres
                if (!context.Genres.Any())
                {
                    context.Genres.AddRange(new List<Genre>()
                    {
                        new Genre()
                        {
                            Id = 1,
                            Name = "Genre 1"
                        },
                        new Genre()
                        {
                            Id = 2,
                            Name = "Genre 2"
                        },
                        new Genre()
                        {
                            Id = 3,
                            Name = "Genre 3"
                        },
                        new Genre()
                        {
                            Id = 4,
                            Name = "Genre 4"
                        },
                        new Genre()
                        {
                            Id = 5,
                            Name = "Genre 5"
                        },

                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Id = 1,
                            Name = "Actor 1",
                            Bio = "Biography of first actor"
                        },
                        new Actor()
                        {
                            Id = 2,
                            Name = "Actor 2",
                            Bio = "Biography of second actor"
                        },
                        new Actor()
                        {
                            Id = 3,
                            Name = "Actor 3",
                            Bio = "Biography of third actor"
                        },
                        new Actor()
                        {
                            Id = 4,
                            Name = "Actor 4",
                            Bio = "Biography of fourth actor"
                        },
                        new Actor()
                        {
                            Id = 5,
                            Name = "Actor 5",
                            Bio = "Biography of fifth actor"
                        },

                    });
                    context.SaveChanges();
                }

                //Genres & Movies
                if (!context.Genres_Movies.Any())
                {
                    context.Genres_Movies.AddRange(new List<Genre_Movie>()
                    {
                        new Genre_Movie()
                        {
                            MovieId = 4,
                            GenreId = 1
                        },
                        new Genre_Movie()
                        {
                            MovieId = 5,
                            GenreId = 2
                        },
                        new Genre_Movie()
                        {
                            MovieId = 5,
                            GenreId = 4
                        },
                        new Genre_Movie()
                        {
                            MovieId = 6,
                            GenreId = 2
                        },
                        new Genre_Movie()
                        {
                            MovieId = 7,
                            GenreId = 3
                        },
                        new Genre_Movie()
                        {
                            MovieId = 7,
                            GenreId = 5
                        },
                        new Genre_Movie()
                        {
                            MovieId = 8,
                            GenreId = 1
                        },
                        new Genre_Movie()
                        {
                            MovieId = 8,
                            GenreId = 2
                        },
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 2,
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 3
                        },
                        new Actor_Movie()
                        {
                            MovieId = 4,
                            ActorId = 4
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 1
                        },
                        new Actor_Movie()
                        {
                            MovieId = 5,
                            ActorId = 3
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 1
                        },
                        new Actor_Movie()
                        {
                            MovieId = 6,
                            ActorId = 5
                        },
                        new Actor_Movie()
                        {
                            MovieId = 7,
                            ActorId = 2
                        },
                        new Actor_Movie()
                        {
                            MovieId = 7,
                            ActorId = 5
                        },
                        new Actor_Movie()
                        {
                            MovieId = 8,
                            ActorId = 3
                        },
                        new Actor_Movie()
                        {
                            MovieId = 8,
                            ActorId = 4
                        },
                        new Actor_Movie()
                        {
                            MovieId = 8,
                            ActorId = 5
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
