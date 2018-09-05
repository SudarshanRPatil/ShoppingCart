using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
