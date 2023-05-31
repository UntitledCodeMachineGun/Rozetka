namespace Rozetka.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SubTitle { get; set; }
        public string TitleImagePath { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyords { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual List<Product> Products { get; set; }

        public Category()
        {
            DateAdded = DateTime.UtcNow;
        }

        public Category(string name, string description, string subTitle, string titleImagePath, string metaTitle, string metaDescription, string metaKeyords, List<Product> products)
        {
            Name = name;

            if (description == null)
            {
                Description = name;
            }
            else
            {
                Description = description;
            }

            if (subTitle == null)
            {
                SubTitle = name;
            }
            else
            {
                SubTitle = subTitle;
            }
            if (titleImagePath != null)
            {
                TitleImagePath = titleImagePath;
            }
            else
            {
                TitleImagePath = "placeholder.jpg";
            }
            if (metaTitle != null)
            {
                MetaTitle = metaTitle;
            }
            else
            {
                MetaTitle = string.Empty;
            }
            if (metaDescription != null)
            {
                MetaDescription = metaDescription;
            }
            else
            {
                MetaDescription = string.Empty;
            }
            if (metaKeyords != null)
            {
                MetaKeyords = metaKeyords;
            }
            else
            {
                MetaKeyords = string.Empty;
            }

            DateAdded = DateTime.UtcNow;

            if (products != null)
            {
                Products = products;
            }
            else 
            {
                Products = new List<Product>();
            }
        }
    }
}
