using Microsoft.AspNetCore.Identity;
namespace WebApplication3.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
        public string CreditCard { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string DeliveryA { get; set; }

        public string AboutMe { get; set; }
    }
}
