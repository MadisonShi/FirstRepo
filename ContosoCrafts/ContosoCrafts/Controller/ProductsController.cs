using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoCrafts.Services;
using ContosoCrafts.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoCrafts.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        public ProductsController(JsonFileProductsService productService)
        {
            ProductsService = productService;
        }

        public JsonFileProductsService ProductsService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductsService.GetProducts();
        }

        [Route("Rate")] //subrating
        [HttpGet] //get is easy to test, probably use patch to update
        public ActionResult Get([FromQuery]string productId,
                                [FromQuery]int rating) //getting productId and rating from url
        {
            ProductsService.AddRating(productId, rating);
            return Ok(); //hids http
        }
    }
}
