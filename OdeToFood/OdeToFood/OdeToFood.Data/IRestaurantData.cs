using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        //IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id); //returns restaurant by id

        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        int Commit();

    } 

    public class InMemoryRestaurantData : IRestaurantData
    {

        readonly List<Restaurant> restaurants;

        //constructor
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location="Maryland", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Cinnamon Club", Location="London", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 3, Name = "La Costa", Location = "California", Cuisine=CuisineType.Mexican}
            };
        }

        /*public IEnumerable<Restaurant> GetAll()
        {
            //return restaurants using Linq
            return from r in restaurants
                   orderby r.Name
                   select r;
        }*/

        public IEnumerable<Restaurant> GetRestaurantsByName(string name=null) //string name is by default null
        {
            //return restaurants using Linq
            return from r in restaurants
                   where string.IsNullOrEmpty(null) || r.Name.StartsWith(name) //where operator will return all if null or just by name
                   orderby r.Name
                   select r;
        }

        public Restaurant GetById(int id) 
        {
            return restaurants.SingleOrDefault(r=>r.Id == id);
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if(restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant;
        }

        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = restaurants.Max(r => r.Id) + 1;
            restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return 0;
        }

        
    }
}
