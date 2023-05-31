using Microsoft.AspNetCore.Identity;

namespace Rozetka.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string DeliveryType { get; set; }
        public string Address { get; set; }
        public string PaymentType { get; set; }
        public bool IsPaid { get; set; }
        public bool IsDone { get; set; }
        public bool IsCancelled { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual User? User { get; set; }
        public virtual List<Product> Products { get; set; }

        public Order()
        {
            DateAdded = DateTime.UtcNow;
        }

        public Order(string description, List<Product> products, User? user)
        {
            if (description != null)
            {
                Description = description;
            }
            else
            { 
                Description = string.Empty;
            }
            DateAdded = DateTime.UtcNow;
            Products = products;
            User = user;
        }
    }
}
