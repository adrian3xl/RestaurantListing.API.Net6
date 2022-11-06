using Microsoft.EntityFrameworkCore;

namespace RestaurantListing.API.Data
{
    public class ResturantListingDBContext : DbContext
    {
        public ResturantListingDBContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                Name = "Jamaica",

            },
            new Country
            {
                Id = 2,
                Name = "Haiti"
            },

            new Country
            {
                Id = 3,
                Name = "Spain"
            }

            );



            modelBuilder.Entity<Resturant>().HasData(new Resturant
            {
                Id = 1,
                Name = "FishPot Stop Resturant ",
                Description = "Provide high quality sea food",
                Rating = "5 Star",
                Address = "Kingston",
                CountryId = 1,
            },
            new Resturant
            {
                Id = 2,
                Name = "HotSause Resturant ",
                Description = "Provide high quality sausy food",
                Rating = "5 Star",
                Address = "Port au Prince",
                CountryId = 2,
            },

            new Resturant
            {
                Id = 3,
                Name = "BullThrust Resturant ",
                Description = "Provide high quality Spanish food",
                Rating = "5 Star",
                Address = "Madrid",
                CountryId = 3,
            }
        );

        }
    }
}
