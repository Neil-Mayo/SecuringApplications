using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{
    public class ProductViewModel
    {
     
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Please input name of product")]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "Name must be composed of letters and numbers")]
        public string Name { get; set; }

        
        [Required(ErrorMessage = "Please input description of product")]

        public string Description { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }


        public CategoryViewModel Category { get; set; }

        public string ImageUrl { get; set; }

        public int Stock { get; set; }
        //public List<CategoryViewModel> Categories { get; set; }


    }
}
