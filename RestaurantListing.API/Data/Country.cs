﻿namespace RestaurantListing.API.Data
{
    public class Country
    {
       public int Id { get; set; }
       public string Name { get; set; }

        public virtual IList<Resturant> Resturants { get; set; }
    }
}