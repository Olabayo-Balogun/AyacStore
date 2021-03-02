﻿using AyacStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacStore.Client.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category {Id = 1, Name = "Vegetables", Url = "vegetables", Icon = "vegetables"},
                new Category {Id = 2, Name = "Fruits", Url = "fruits", Icon = "fruits"},
                new Category {Id = 3, Name = "Cereals", Url = "cereals", Icon = "cereals"}
            };
        }
    }
}
