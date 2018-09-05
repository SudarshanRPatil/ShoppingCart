using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Entities;

namespace ShoppingCart.DataAccessLayer
{
    public interface IOperations
    {
        List<Category> GetCategories();
        List<Product> GetProducts();
    }
}
