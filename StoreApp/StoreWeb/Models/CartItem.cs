using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreWeb2.Models
{
    public class CartItem
    {
        [HiddenInput(DisplayValue = false)]
        [DisplayName("Item ID")]
        public int ID { get; set; }
        [Required]
        [DisplayName("Product ID")]
        public int ProductID { get; set; }
        [Required]
        [DisplayName("Quantity Available")]
        public string Quantity { get; set; }
        [Required]
        [DisplayName("Cart ID")]
        public string CartID { get; set; }
    }
    public class EmpDBContextCI : DbContext
    {
        public DbSet<CartItem> CartItem { get; set; }
    }
}