using Microsoft.AspNetCore.Identity;

namespace HotelBooking.Application.CommonModel
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
