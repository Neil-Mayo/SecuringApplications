using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Application.Interfaces
{
    public interface IProductsService
    {
        IQueryable<ProductViewModel> GetProducts();
        IQueryable<ProductViewModel> GetProducts(string keyword);

        ProductViewModel GetProduct(Guid id);

        void AddProduct(ProductViewModel model);


        void DeleteProduct(Guid id);

        IQueryable<ProductViewModel> GetNextProducts(int noOfRecords, int starting);
        IQueryable<ProductViewModel> GetPreviousProducts(int noOfRecords, int starting);
    }
}
