using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;
using OdeToFood.Core;

//performs data access and puts together data for List.cshtml to display

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config; //allow access to IConfig 
        private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet=true)] public string searchTerm { get; set; } //needs supportsget bc bindpropety only binds post op inputs

        public ListModel(IConfiguration config, IRestaurantData restaurantData) //constructor that takes in an iconfig
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Message = config["Message"]; //sets message equal to message propety from appsettings.json
            //Restaurants = restaurantData.GetAll();
            Restaurants = restaurantData.GetRestaurantsByName(searchTerm);
        }
    }
}
