using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Entities;


namespace ShoppingCart.BusinessLayer
{
    interface IShoppingCartOperations
    {
        void AddToCart(int id);
        string GetCartId();
        List<CartItem> GetCartItems();
        void RemoveItem(string removeCartID, int removeProductID);
        void UpdateItem(string updateCartID, int updateProductID, int quantity);
        void EmptyCart();
        int GetCount();
        decimal GetTotal();
    }
}
