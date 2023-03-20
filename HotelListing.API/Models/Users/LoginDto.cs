using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Users
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required] // Εχει καποια validations oute of the box απτον identity
        public string Password { get; set; }
    }
}
