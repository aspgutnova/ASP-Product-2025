using ShopFood.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopFood
{
    public class CartsRepository
    {
        private List<Cart> carts=new List<Cart>();
        public Cart TryGetByUserId(int userid)
        {
            return carts.FirstOrDefault(x => x.UserId == userid);
        }

        public void Add(int userid, Product product)
        {
            carts.Add(new Cart(userid, new CartItem(product)));
        }
    }
}
