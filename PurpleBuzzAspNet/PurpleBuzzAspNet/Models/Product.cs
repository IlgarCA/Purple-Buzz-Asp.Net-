namespace PurpleBuzzAspNet.Models
{
    public class Product
    {
        public Product()
        {
            ProductImages = new List<ProductImage>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public List<ProductImage> ProductImages { get; set; }
    }
}
