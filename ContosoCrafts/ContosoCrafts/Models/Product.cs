﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.Models
{
    public class Product
    { 
        public string Id { get; set; }
        public string Maker { get; set; }
        [JsonPropertyName("img")] //maps img to Image
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this); //=> LINQ syntax; for 1 line returns
        
    }
}
