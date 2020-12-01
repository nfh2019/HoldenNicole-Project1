﻿using System.Collections.Generic;

namespace StoreDB.Entities
{
    public partial class Products
    {
        public Products()
        {
            CartItems = new HashSet<CartItems>();
            Inventory = new HashSet<Inventory>();
        }

        public int Id { get; set; }
        public string Athlete { get; set; }
        public string Item { get; set; }
        public string Sport { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<CartItems> CartItems { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
