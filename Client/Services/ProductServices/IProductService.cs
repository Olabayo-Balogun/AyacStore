using AyacStore.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AyacStore.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
    }
}