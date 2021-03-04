using AyacStore.Server.Services.CategoryService;
using AyacStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacStore.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p  => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
            {
                 new Product {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Tomatoes",
                    Description = "Fresh Tomatoes sourced directly from farmers in order to provide you with high quality at a price you love",
                    Image = "https://media.istockphoto.com/photos/tomato-isolated-tomato-on-white-background-with-clipping-path-full-picture-id941825808?k=6&m=941825808&s=612x612&w=0&h=zMkokhq3w7fN5xYeiTX27c6TICJ53ZvZg9AY2LNgw_0=",
                    Price = 99.99m,
                    OriginalPrice = 200m,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Strawberry",
                    Description = "Fresh Strawberry sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; strawberry isn't a berry, botanists acknowledge strawberry as a false fruit because of it's multiple fruit nature",
                    Image = "https://www.thermofisher.com/blog/food/wp-content/uploads/sites/5/2015/08/single_strawberry__isolated_on_a_white_background.jpg",
                    Price = 999.99m,
                    OriginalPrice = 2000m,
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Pepper",
                    Description = "Fresh pepper sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; pepper isn't a vegetable, botanists acknowledge pepper as a fruit because of the location of its seed",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYdRaqkMUhc4WxHJcT0c9JRCfmdvWpdJUCOQ&usqp=CAU",
                    Price = 99.99m,
                    OriginalPrice = 200m,
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 3,
                    Title = "Corn",
                    Description = "Fresh corn sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; corn is one of the top three most consumed crop in the world",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYYVJEFeOlfYCHaynRROL_MLI2AbF1Aa4aUw&usqp=CAU",
                    Price = 99.99m,
                    OriginalPrice = 200m,
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Rice",
                    Description = "Fresh rice sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; rice is one of the top three most consumed crop in the world",
                    Image = "https://m.economictimes.com/thumb/msid-75184562,width-1200,height-900,resizemode-4,imgsize-414299/rice.jpg",
                    Price = 19999.99m,
                    OriginalPrice = 25000m,
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Plantain",
                    Description = "Fresh plantain sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; plantain isn't a fruit, botanists acknowledge plantain as a berry fruits are defined by the manner and location of their seeds",
                    Image = "https://eatyfood.com/wp-content/uploads/2020/08/plantains.jpg",
                    Price = 199.99m,
                    OriginalPrice = 400m,
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "Banana",
                    Description = "Fresh banana sourced directly from farmers in order to provide you with high quality at a price you love.  Fun fact; banana isn't a fruit, botanists acknowledge plantain as a berry fruits are defined by the manner and location of their seeds",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRi94BSgqwm6Zzv7mx3DJWxYRWNUPC0gf3pOA&usqp=CAU",
                    Price = 199.99m,
                    OriginalPrice = 400m,
                }
            };
    }
}
