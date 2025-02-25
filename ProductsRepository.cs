using ShopFood.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopFood
{
    public class ProductsRepository
    {
        private static List<Product> products = new List<Product>()
            {
                new Product("Xioami",1000000,"https://avatars.mds.yandex.net/i?id=8ae905ba1cd836ab6ef4267d99e42097ecfa2ae2-11511205-images-thumbs&n=13","сяоми"),
                new Product("Пылесос - Philips",25000,"https://avatars.mds.yandex.net/i?id=80ada557d8c75676fd7c424ec9cd2dd647210fd0a24f438d-12417143-images-thumbs&n=13","пыль")
            };
        
        public List<Product> GetAll()
        {
            return products;
        }
        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }
    }
}
