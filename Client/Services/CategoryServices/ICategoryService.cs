﻿using AyacStore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacStore.Client.Services.CategoryServices
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
