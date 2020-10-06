using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ContosoCrafts.Services;
using ContosoCrafts.Models;

namespace ContosoCrafts.Pages
{
    public class IndexModel : PageModel 
    {
        private readonly ILogger<IndexModel> _logger; //service
        public JsonFileProductsService _productService;
        public IEnumerable<Product> products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductsService productService)
        {
            _logger = logger;
            _productService = productService; 
        }

        public void OnGet() //getting this page; also OnPost, etc 
        {
            products = _productService.GetProducts();
        }
    }
}
