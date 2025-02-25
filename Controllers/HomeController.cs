using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopFood.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShopFood.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private ProductsRepository productsRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            productsRepository = new ProductsRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            List<Product> products = productsRepository.GetAll();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
