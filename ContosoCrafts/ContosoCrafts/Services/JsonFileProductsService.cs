using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ContosoCrafts.Models;
using Microsoft.AspNetCore.Hosting;

namespace ContosoCrafts.Services
{
    public class JsonFileProductsService
    {
        public JsonFileProductsService(IWebHostEnvironment webHostEnvironment) //constructor
        {
            WebHostEnvironment = webHostEnvironment; //service that knows where everything (like data file) is located
        } 

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); } //finds products file in your library system
        }

        public IEnumerable<Product> GetProducts() //IEnumerable - generator for foreach
        {
            using (var jsonFileReader = File.OpenText(JsonFileName)) //open file
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(), //deserialize, make array of products
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true //don't case about case
                    });
            }
        }

        public void AddRating(string productId, int rating)
        {
            var products = GetProducts();

            if (products.First(x => x.Id == productId).Ratings == null)
            {
                products.First(x => x.Id == productId).Ratings = new int[] { rating };
            }
            else
            {
                var ratings = products.First(x => x.Id == productId).Ratings.ToList();
                ratings.Add(rating);
                products.First(x => x.Id == productId).Ratings = ratings.ToArray();
            }

            using (var outputStream = File.OpenWrite(JsonFileName)) //open up file again
            {
                JsonSerializer.Serialize<IEnumerable<Product>>( //adding it back into the json file
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions //utf8 - for any lang
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    products
                );
            }
        }
    }
}


