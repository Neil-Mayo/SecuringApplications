using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Data.Repositories
{
    public class CategoriesRepository : ICategoryRepository
    {
        private ShoppingCartDbContext _context;
        public CategoriesRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public IQueryable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}
