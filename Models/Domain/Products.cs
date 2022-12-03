namespace Less16_Controllers.Models.Domain
{
    [Serializable]
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductsType Type { get; set; }
        public Products() { }
        public Products(int id, string name, decimal price, ProductsType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
