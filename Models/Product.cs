namespace ShopFood.Models
{
    public class Product
    {
        private static int id = 0;
        public int Id {get;}
        public string Description { get; }
        public string Name { get;}
        public decimal Cost{get;}
        public string Image { get; }
        public override string ToString()
        {
            return $"{id} {Name} {Cost}";
        }
        public Product(string name, decimal cost,string img,string desc)
        {
            Id = ++id;
            Name = name;
            Cost = cost;
            Image = img;
            Description = desc;
        }
    }
}
