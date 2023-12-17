using HotelBooking.Application.Interface;
using HotelBooking.Application.RequestAndResponseType;
using HotelBooking.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddRoomsController : ControllerBase
    {
        private readonly IAddRoomService _service;
        public AddRoomsController(IAddRoomService service)
        {
            _service = service;
        }

        /// <summary>
        /// Adding Number of Rooms 
        /// </summary>
        /// <param name="createRooms"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("AddRoomInfo")]
        public async Task<ActionResult> Create([FromBody] CreateRoomsDto createRooms)
        {
            await _service.CreateAsync(createRooms);
            return Ok("Rooms Added SuccessFully!");
        }



        /// <summary>
        /// Get The OverAll RoomsDetails 
        /// </summary>
        /// <param name="GetListOfRoomsDetails"></param>
        /// <returns>List Of Room list</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("GetRoomsInfo")]
        public async Task<ActionResult<List<AddRoomsDto>>> GetAll()
        {
            var roomList =  await _service.GetAllAsync();
            return Ok(roomList);
        }


        /// <summary>
        /// Get The specific RoomsDetails 
        /// </summary>
        /// <param name="GetRoomDetail"></param>
        /// <returns>RoomDetail Based on condition</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("GetRoomInfo")]
        public async Task<ActionResult<AddRoomsDto>> GetById(int id)
        {
            var room = await _service.GetByIdAsync(id);
            return Ok(room);
        }


        /// <summary>
        /// Update The specific RoomsDetails 
        /// </summary>
        /// <param name="UpdateRoomDetail"></param>
        /// <returns> Update RoomDetail Based on condition</returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        [Route("UpdateRoomInfo")]
        public async Task<ActionResult> Update(AddRoomsDto addRooms)
        {
             await _service.UpdateAsync(addRooms);
             return Ok("Updated SuccessFully");
        }



        /// <summary>
        /// Delete The specific RoomsDetails 
        /// </summary>
        /// <param name="DeleteRoomDetails"></param>
        /// <returns> Delete RoomDetail Based on condition</returns>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete]
        [Route("RemoveRoomInfo")]
        public async Task<ActionResult> Delete(AddRoomsDto addRooms)
        {
            var exitsData = await _service.GetByIdAsync(addRooms.Id);
            if(exitsData != null)
            {
                await _service.DeleteAsync(addRooms.Id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

    }
}