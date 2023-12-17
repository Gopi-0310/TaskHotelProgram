using HotelBooking.Application.CommonModel;
using HotelBooking.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IAuthService _auth;
        public RegisterController(IAuthService service)
        {
            _auth = service;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(Registration registration)
        {
           
                await _auth.Register(registration);
                return Ok(registration);
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
              var result =   await _auth.Login(login);
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
    
}
