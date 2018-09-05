using System;
using System.Collections.Generic;
using ShoppingCart.Entities;

namespace ShoppingCart.DataAccessLayer
{
    public class ProductDBOperations : IOperations
    {
        public List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Books"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Electronics"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Toys"
                }
            };

            return categories;
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible Car",
                    Description = "This convertible car is fast!",
                    UnitPrice = 22.50,
                    CategoryID = 3
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Old Style Racer",
                    Description = "This old style racer can fly (with user assistance).",
                    UnitPrice = 34.95,
                    CategoryID = 3
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Samsung Galaxy J8",
                    Description = "Samsung Galaxy J8 (Black, 64GB) with Offers",
                    UnitPrice = 17990,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "RealMe 1",
                    Description = "RealMe 1 (Diamond Black, 4+64 GB)",
                    UnitPrice = 10990,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Investing in India",
                    Description = "Investing in India: A Value Investors Guide to the Biggest Untapped Opportunity in the World",
                    UnitPrice = 251.48,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Think & Grow Rich",
                    Description = "Think & Grow Rich",
                    UnitPrice = 38.00,
                    CategoryID = 1
                }
            };

            return products;
        }
    }
}
