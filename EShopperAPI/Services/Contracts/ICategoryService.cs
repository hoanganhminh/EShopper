﻿using EShopperAPI.Data.RequestDTO;
using EShopperAPI.Models;

namespace EShopperAPI.Services.Contracts
{
    public interface ICategoryService
    {
        public Task<List<CategoryResponse>> GetAllCategories();
    }
}
