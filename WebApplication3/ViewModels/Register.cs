using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebApplication3.ViewModels
{
	public class Register
	{

        public string id { get; set; }
        [Required]
		[DataType(DataType.Text)]
		public string FullName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string CreditCard { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required, RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{12,}$", ErrorMessage = "Password must have minimum 12 chars, one lower-case and upper-case, number and one special character")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = "Password and confirmation password does not match")]
		public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [Required, RegularExpression(@"^[689]\d{7}$", ErrorMessage = "Invalid Phone Number"), MaxLength(8)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string DeliveryA { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string AboutMe { get; set; }

    }
}
