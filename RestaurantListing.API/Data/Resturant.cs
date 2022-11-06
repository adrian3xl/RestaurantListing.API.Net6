using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantListing.API.Data
{
    public class Resturant
    {
        int Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        string Rating { get; set; }


        [ForeignKey(nameof(CountryId))]
        int CountryId { get; set; }

        public Country Country { get; set; }


    }
}
