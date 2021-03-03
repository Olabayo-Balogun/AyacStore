﻿using AyacStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AyacStore.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadProducts(string categoryUrl = null)
        {
            Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/{categoryUrl}");
        }
    }
}
