using OdeToFood.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Hermanus's Pizza", Cuisine = CuisineType.Italian },  
                new Restaurant { Id = 2, Name = "La resistance", Cuisine = CuisineType.French },  
                new Restaurant { Id = 3, Name = "Papriika", Cuisine = CuisineType.Indian }  
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
