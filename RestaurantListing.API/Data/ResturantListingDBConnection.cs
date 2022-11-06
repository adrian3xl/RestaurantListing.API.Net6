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

    }
}
