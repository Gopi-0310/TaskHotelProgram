using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Application.RequestAndResponseType
{
    public class CreateRoomsDto
    {
        [Required]
        public string RoomNumber { get; set; }
        [Required]
        public string RoomTypes { get; set; }
    }
}
