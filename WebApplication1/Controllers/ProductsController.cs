using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {

        public readonly IProductsService _prodService;
        public ProductsController(IProductsService prodService)
        {
            _prodService = prodService;
        }
        public IActionResult Index()
        {
            var list =  _prodService.GetProducts();
            return View(list);
        }

        public IActionResult Create()
        { return View(); }

        [HttpPost]  
        public IActionResult Create(ProductViewModel data )
        {
            /*
            if(data.Name == "")
            {
                TempData["errror"] = "Name is empty";
                return View();
            }
            */

            data.Description = HtmlEncoder.Default.Encode(data.Description);


            if (ModelState.IsValid)
            {
                if(data.Category.Id > 1 && data.Category.Id < 4)
                {
                    ModelState.AddModelError("Category.Id", "Category is not valid");
                    return View(data);
                }

                //once the product has been inserted successfully in the db

                _prodService.AddProduct(data);

                TempData["message"] = "product inserted successfully";
                return View();
            }
            else
            {
                return View(data);
            }
            
        }
    }
}
