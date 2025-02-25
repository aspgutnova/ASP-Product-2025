namespace ShopFood.Models
{
    public class Product
    {
        public int id {get;}
        public string Description { get; }
        public string Name { get;}
        public decimal Cost{get;}
        public string Image { get; }
        public override string ToString()
        {
            return $"{id} {Name} {Cost}";
        }
        public Product(int id, string name, decimal cost,string img,string desc)
        {
            this.id = id;
            Name = name;
            Cost = cost;
            Image = img;
            Description = desc;
        }
    }
}
