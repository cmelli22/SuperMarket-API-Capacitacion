﻿using Supermarket.API.Domain.Models;
using Supermarket.API.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category cateogry);
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
        void Delete(Category category);
    }
}
