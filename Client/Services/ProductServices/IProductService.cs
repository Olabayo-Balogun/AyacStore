using AyacStore.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AyacStore.Client.Services.ProductServices
{
    public interface IProductService
    {
        event Action OnChange; 
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);

        Task<Product> GetProduct(int id);
    }
}