using System;

namespace ShopFood.Models
{
    public class CartItem
    {
        public Guid Id { get; }
        public Product Item { get; }
        public int Amount { get; set; }
        public decimal Cost { get; }
        public decimal Total
        {
            get
            {
                return Amount * Cost;
            }
        }

        public CartItem(Product item)
        {
            Id = Guid.NewGuid();
            Item = item;
            Amount = 1;
            Cost = item.Cost;
        }
    }
}
