using HotelBooking.Application.CommonModel;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Application.Interface
{
    public interface IAuthService
    {
        Task<IEnumerable<IdentityError>> Register(Registration register);

        Task<object> Login(Login login);
    }
}
