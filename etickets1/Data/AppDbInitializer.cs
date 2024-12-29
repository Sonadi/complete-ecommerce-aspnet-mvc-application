using etickets1.Data.Enums;
using etickets1.Models;

namespace etickets1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any()) {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema() {
                            Name = "Cinema 1",
                            Logo = "https://png.pngtree.com/png-clipart/20190516/original/pngtree-movie-cinema-entertainment-logo-with-neon-sign-effect-vector-illustration-png-image_3669644.jpg",
                            Description = "This is the description if the first cinema"
                        },
                        new Cinema() {
                            Name = "Cinema 2",
                            Logo = "https://static.vecteezy.com/system/resources/previews/001/213/226/original/bright-neon-cinema-sign-with-popcorn-vector.jpg",
                            Description = "This is the description if the second cinema"
                        },
                        new Cinema() {
                            Name = "Cinema 3",
                            Logo = "https://thumbs.dreamstime.com/b/abstract-cinema-logo-vector-template-isolated-white-background-79853753.jpg",
                            Description = "This is the description if the third cinema"
                        },

                    }
                        );
                    context.SaveChanges();

                }
                //actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() { 
                    
                        new Actor() { 
                          FullName = "Actor 1",
                          Bio = "This is the bio for the first actor",
                          ProfilePictureURL = "https://1.bp.blogspot.com/-NtbFO5Wl_co/XxqFwTeqmKI/AAAAAAAAApo/AlwVGE9aNFYBh6Wcnnc7_jYI2KTkw5pegCNcBGAsYHQ/s1200/Robert+Downey+Jr.jpg"
                        },
                        new Actor() {
                          FullName = "Actor 2",
                          Bio = "This is the bio for the second actor",
                          ProfilePictureURL = "http://i.huffpost.com/gen/920563/thumbs/o-BEST-ACTOR-GOLDEN-GLOBES-facebook.jpg"
                        },
                        new Actor() {
                          FullName = "Actor 3",
                          Bio = "This is the bio for the third actor",
                          ProfilePictureURL = "https://3.bp.blogspot.com/-_k0O1cwQOAU/TqMSfb-zCkI/AAAAAAAAD-0/X67Jhv_e5Rc/s1600/Beautiful-Smiling-Picture-of-Shahrukh-Khan-in-Black-Outfit.-Free-Download.jpg"
                        }

                    });
                    context.SaveChanges();

                }
                //producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>() {
                    new Producer() {
                        FullName = "Producer 1",
                        Bio = "This is the Bio of the first producer",
                        ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-1-4.png"
                    },
                    new Producer() {
                        FullName = "Producer 2",
                        Bio = "This is the Bio of the second producer",
                        ProfilePictureURL = "http://wintersbonemovie.com/wp-content/uploads/2020/09/20200515_021527-768x551.jpg"
                    },
                    new Producer() {
                        FullName = "Producer 3",
                        Bio = "This is the Bio of the third producer",
                        ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-2-4.jpg"
                    },
                    });
                    context.SaveChanges();
                }
                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() { 
                    new Movie() { 
                        Name = "Pathaan",
                        Description = "This is the Pathaan movie description",
                        Price = 39.50,
                        ImageURL = "https://www.bollywoodhungama.com/wp-content/uploads/2022/11/Pathaan-5.jpg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 3,
                        ProducerId = 3,
                        MovieCategory = Moviecategory.Adventures
                    },
                    new Movie() {
                        Name = "Vampire Diary",
                        Description = "This is the Vampire Diary movie description",
                        Price = 39.50,
                        ImageURL = "https://m.media-amazon.com/images/M/MV5BODhiODk3NWEtZmNiYi00N2NlLThlN2YtN2VkYTYyMjQxMWEzXkEyXkFqcGdeQXVyNjU2NjA5NjM@._V1_.jpg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 2,
                        ProducerId = 2,
                        MovieCategory = Moviecategory.Thriller
                    },
                    new Movie() {
                        Name = "Iron Man2",
                        Description = "This is the Iron Man2 movie description",
                        Price = 39.50,
                        ImageURL = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/7aef62a0-8ac5-4f89-87c8-ab0d8bac3763/dcthujr-2c8cb375-a298-4aa5-b083-fbdfcfbb35b5.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzdhZWY2MmEwLThhYzUtNGY4OS04N2M4LWFiMGQ4YmFjMzc2M1wvZGN0aHVqci0yYzhjYjM3NS1hMjk4LTRhYTUtYjA4My1mYmRmY2ZiYjM1YjUuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.vDnYU3hUKOsYAIWhjJymRySfuoqYXHOu38hif6cf4Q8",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 1,
                        MovieCategory = Moviecategory.Thriller
                    },
                    });
                    context.SaveChanges();

                }

                //actors & movies
                if (!context.Actors_Movies.Any())
                {
                    
                    var movie1 = context.Movies.FirstOrDefault(m => m.Name == "Vampire Diary");
                    var movie2 = context.Movies.FirstOrDefault(m => m.Name == "Pathaan");
                    var movie3 = context.Movies.FirstOrDefault(m => m.Name == "Iron Man2");

                    var actor1 = context.Actors.FirstOrDefault(a => a.FullName == "Actor 1");
                    var actor2 = context.Actors.FirstOrDefault(a => a.FullName == "Actor 2");

                    
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie() { ActorId = actor1.Id, MovieId = movie2.Id },
                        new Actor_Movie() { ActorId = actor2.Id, MovieId = movie1.Id },
                        new Actor_Movie() { ActorId = actor1.Id, MovieId = movie3.Id }
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
