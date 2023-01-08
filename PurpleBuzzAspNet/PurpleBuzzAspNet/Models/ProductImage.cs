namespace PurpleBuzzAspNet.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public bool IsMain { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
