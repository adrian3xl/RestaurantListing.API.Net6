namespace RestaurantListing.API.Data
{
    public class Country
    {
        int id { get; set; }
        string name { get; set; }

        public virtual IList<Resturant> Resturants { get; set; }
    }
}