using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Entities
{
    public class ProductContext : IDisposable
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<CartItem> ShoppingCartItems { get; set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
