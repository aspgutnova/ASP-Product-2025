using System;
using System.Collections.Generic;

namespace ShopFood.Models
{
    public class Cart
    {
        public int UserId { get; }
        public List<CartItem> Items { get; }

        public Cart(int userId, CartItem items)
        {
            UserId = userId;
            Items = new List<CartItem>();
            Items.Add(items);
        }
    }
}
