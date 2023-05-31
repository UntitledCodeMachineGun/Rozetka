namespace Rozetka.Domain.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public DateTime DateAdded { get; set; }

        public ProductImage()
        {
            DateAdded = DateTime.UtcNow;
        }

        public ProductImage(string path)
        {
            if (path != null)
            {
                Path = path;
            }
            else
            {
                Path = "placeholder.jpg";
            }
            DateAdded = DateTime.UtcNow;
        }
    }
}
