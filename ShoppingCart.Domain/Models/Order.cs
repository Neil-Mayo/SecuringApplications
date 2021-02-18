using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public string Email { get; set; }
        

    }
}
