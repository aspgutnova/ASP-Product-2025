using Microsoft.AspNetCore.Mvc;
using ShopFood.Models;
using System.Linq;

namespace ShopFood.Controllers
{
    public class CartController : Controller
    {
        private CartsRepository cartsRepository;
        private ProductsRepository productsRepository;

        public CartController()
        {
            cartsRepository = new CartsRepository();
            productsRepository = new ProductsRepository();
        }

        public IActionResult Index()
        {
            var cart = cartsRepository.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int productid)
        {
            Product product = productsRepository.TryGetById(productid);
            if (product == null)
            { }
            else
            {
                var existingcart = cartsRepository.TryGetByUserId(Constants.UserId);
                if (existingcart != null)
                {
                    var existingproduct = existingcart.Items.FirstOrDefault(x => x.Item.Id == product.Id);
                    if (existingproduct != null)
                    {
                        existingproduct.Amount++;
                    }
                    else
                    {
                        existingcart.Items.Add(new CartItem(product));
                    }
                }
                else
                {
                    cartsRepository.Add(Constants.UserId, product);
                }
            }
            return View();
        }
    }
}
