using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.CommonModel
{
    public class Login
    {
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
