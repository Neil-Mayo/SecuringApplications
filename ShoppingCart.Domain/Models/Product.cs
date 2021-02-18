using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
      
        [Required]
        public double Price { get; set; }

        public int Stock { get; set; }

        [Required]
        public virtual Category Category { get; set; }

       
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public string ImageUrl { get; set; }


       // public bool Disabled { get; set; }


        //supplier/ warehouse/ shelving info/ manager responsible for this product/ unit price

    }
}
