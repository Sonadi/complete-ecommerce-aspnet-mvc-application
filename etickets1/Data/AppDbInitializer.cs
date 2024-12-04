namespace etickets1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) {

                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any()) { 

                }
                //actors
                if (!context.Actors.Any())
                {

                }
                //movies
                if (!context.Movies.Any())
                {

                }
                //producers
                if (!context.Producers.Any())
                {

                }
                //actors & movies
                if (!context.Actors_Movies.Any())
                {

                }
            }
        }
    }
}
