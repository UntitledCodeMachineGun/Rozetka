using Microsoft.AspNetCore.Identity;

namespace Rozetka.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? FatherName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? AdditionalInfo { get; set; }
        public List<Order>? Orders { get; set; }

        public User() { }

        public User(string firstName, string lastName, string? fatherName, DateTime? dateOfBirth, string? address, string? additionalInfo)
        { 
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            DateOfBirth = dateOfBirth;
            Address = address;
            AdditionalInfo = additionalInfo;
        }


    }
}
