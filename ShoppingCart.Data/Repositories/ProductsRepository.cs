using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShoppingCart.Data.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        ShoppingCartDbContext _context;
        public ProductsRepository(ShoppingCartDbContext context )
        {

            _context =   context;
        }

        public Guid AddProduct(Product p)
        {
          // p.Category = null; //because the runtime thinks that it needs to add a new category
           
            _context.Products.Add(p);
            _context.SaveChanges();

            return p.Id;
        }

        public void DeleteProduct(Guid id)
        { 
            Product p = GetProduct(id);
            _context.Products.Remove(p);
            _context.SaveChanges();
        }

        public Product GetProduct(Guid id)
        { 
            return _context.Products.Include(x => x.Category).SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<Product> GetProducts()
        { 
            return _context.Products.Include(x=>x.Category);
        }

      /*  public void HideProduct(Guid id)
        {
            GetProduct(id).Disabled = true;
            _context.SaveChanges();

        }*/
    }
}
