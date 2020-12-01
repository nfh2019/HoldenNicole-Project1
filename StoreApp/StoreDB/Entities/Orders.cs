﻿using System;
using System.Collections.Generic;

namespace StoreDB.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            LineItems = new HashSet<LineItems>();
        }

        public int Id { get; set; }
        public int Customer { get; set; }
        public int Location { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }

        public virtual Customer CustomerNavigation { get; set; }
        public virtual Locations LocationNavigation { get; set; }
        public virtual ICollection<LineItems> LineItems { get; set; }
    }
}
