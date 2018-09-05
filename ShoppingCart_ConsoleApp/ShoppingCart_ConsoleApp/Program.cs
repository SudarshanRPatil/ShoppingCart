using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Entities;
using ShoppingCart.BusinessLayer;
using ShoppingCart.DataAccessLayer;

namespace ShoppingCart_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperations dbOperations = new ProductDBOperations();

            List<Category> categories = dbOperations.GetCategories();
            List<Product> products = dbOperations.GetProducts();

            List<CartItem> shoppingCartItems = new List<CartItem>();
            var prodcontext = new ProductContext();
            prodcontext.ShoppingCartItems = shoppingCartItems;
            prodcontext.Products = products;
            prodcontext.Categories = categories;

            using (var shopingCartOperation = new ShoppingCartOperations(prodcontext))
            {
                shopingCartOperation.AddToCart(prodcontext.Products[2].ProductID);
                shopingCartOperation.AddToCart(prodcontext.Products[4].ProductID);
                shopingCartOperation.AddToCart(prodcontext.Products[2].ProductID);
                var cartItems = shopingCartOperation.GetCartItems();

                Console.WriteLine("=================CART DETAILS START========================");
                foreach (var item in cartItems)
                {
                    Console.WriteLine("-------------ProductDetails START---------------");
                    Console.WriteLine("ProductId: {0}", item.ProductId);
                    Console.WriteLine("Quantity {0}", item.Quantity);
                    Console.WriteLine("ProductName {0}", item.Product.ProductName);
                    Console.WriteLine("Price {0}", item.Product.UnitPrice);
                    Console.WriteLine("ProductDescription {0}", item.Product.Description);
                    Console.WriteLine("-------------ProductDetails END-----------------");
                }
                Console.WriteLine("=================CART DETAILS END========================");
                //Console.WriteLine("Product Count: {0}", shopingCartOperation.GetCount());
                Console.WriteLine("################# Billing Details #########################");
                Console.WriteLine("Product Total: {0}", shopingCartOperation.GetTotal());
                shopingCartOperation.EmptyCart();
                //Console.WriteLine("Product Count: {0}", shopingCartOperation.GetCount());
            }


            Console.ReadKey();
        }
    }
}
