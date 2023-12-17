using HotelBooking.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Domain.Model
{
    public class AddRooms : BaseModel
    {
        [Required]
        public string RoomNumber { get; set; }
        [Required]
        public string RoomTypes { get; set; }
    }
}
