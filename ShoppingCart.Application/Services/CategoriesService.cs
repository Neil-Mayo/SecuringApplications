using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Interfaces;

namespace ShoppingCart.Application.Services
{
    public class CategoriesService : ICategoriesService
    {
        private ICategoryRepository _categoriesRepo;
        public CategoriesService(ICategoryRepository categoriesRepo)
        {
            _categoriesRepo = categoriesRepo;
        }

        public IQueryable<CategoryViewModel> GetCategories()
        {
            var list = from c in _categoriesRepo.GetCategories()
                       select new CategoryViewModel()
                       {
                           Id = c.Id,
                           Name = c.Name
                       };

            return list;
        }
    }
}
