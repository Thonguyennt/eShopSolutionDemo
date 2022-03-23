﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Catagory.Categories;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Application.Catagory.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly EshopDbContext _context;
        public CategoryService(EshopDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId
                        select new { c, ct };


            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.ct.Name
            }).ToListAsync();
        }
    }
}

