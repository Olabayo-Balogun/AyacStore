using AyacStore.Shared;
using System.Collections.Generic;

namespace AyacStore.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}