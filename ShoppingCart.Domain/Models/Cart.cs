using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    public class Cart
    {
        // [autogeneration]
        public int Id { get; set; }

        public string Email { get; set; }


        public Guid ProductFk { get; set; }
        public virtual Product Product {get;set;}

        public int Quantity { get; set; }
    }
}
