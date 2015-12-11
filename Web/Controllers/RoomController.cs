using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// Handle all Room-Requests (/api/Room)
    /// </summary>
    /// <author>Lucas Engel</author>
    public class RoomController : BaseController
    {
        #region Dependencies
        private readonly RoomService _roomService;
        #endregion

        /// <summary>
        /// Initialize the RoomController.
        /// </summary>
        public RoomController()
        {
            _roomService = new RoomService();
        }

        /// <summary>
        /// Get a specific Room by their ID.
        /// </summary>
        /// <param name="p_id">ID of the room.</param>
        /// <returns>Roomobject, or NULL.</returns>
        public HttpResponseMessage Get([FromUri(Name = "ID")] int p_id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _roomService.GetById(p_id));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
        
        /// <summary>
        /// Get a Collection of all Rooms in a Hotel.
        /// </summary>
        /// <param name="p_hotel">Hotelobject with at least the ID of the Hotel.</param>
        /// <returns>Filled, or empty Collection.</returns>
        public HttpResponseMessage Get([FromUri(Name = "Hotel")] DomainModel.Hotel p_hotel)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _roomService.GetCollectionByHotel(p_hotel));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
        
        /// <summary>
        /// Get all Rooms wich are availble between a specific timeframe.
        /// </summary>
        /// <param name="p_id">ID of the desired Hotel.</param>
        /// <param name="p_arrival">Arrivaldate.</param>
        /// <param name="p_departure">Departuredate.</param>
        /// <returns>Filled, or empty Collection.</returns>
        public HttpResponseMessage Get([FromUri(Name = "HotelId")] int p_id, [FromUri(Name = "Arrival")] DateTime p_arrival, [FromUri(Name = "Departure")] DateTime p_departure)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _roomService.GetAvailableRooms(p_id, p_arrival, p_departure));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
        
        /// <summary>
        /// Add a new Room to the database.
        /// </summary>
        /// <param name="p_room">The new Roomobject without an ID.</param>
        /// <returns>Roomobject with a set ID.</returns>
        public HttpResponseMessage Post([FromBody]Room p_room)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _roomService.Save(p_room));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
        
        /// <summary>
        /// Update an existing Room.
        /// </summary>
        /// <param name="p_room">Roomobject with an ID set.</param>
        /// <returns>The same Roomobject, or NULL.</returns>
        public HttpResponseMessage Put([FromBody]Room p_room)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _roomService.Save(p_room));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// Delete a room in the database.
        /// </summary>
        /// <param name="p_id">ID of the room.</param>
        /// <returns>The deleted Roomobject, or NULL.</returns>
        public HttpResponseMessage Delete([FromUri]int p_id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _roomService.DeleteById(p_id));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// Delete a room in the database.
        /// </summary>
        /// <param name="p_room">Roomobject with set ID.</param>
        /// <returns>The deleted Roomobject, or NULL.</returns>
        public HttpResponseMessage Delete([FromUri]Room p_room)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _roomService.Delete(p_room));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
    }
}