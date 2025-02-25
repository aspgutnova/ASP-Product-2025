using Microsoft.AspNetCore.Mvc;

namespace ShopFood.Controllers
{
    public class ProductController : Controller
    {
        private ProductsRepository productsRepository;

        public ProductController()
        {
            productsRepository = new ProductsRepository();
        }

        public IActionResult Index(int id)
        {
            var product = productsRepository.TryGetById(id);
            ViewBag.Id = id;
            return View(product);
        }
    }
}
