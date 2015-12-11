using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// Handle all Hotel-Requests (/api/Hotel)
    /// </summary>
    /// <author>Lucas Engel</author>
    public class HotelController : BaseController
    {
        #region Dependencies
        private readonly HotelService _hotelService;
        #endregion

        /// <summary>
        /// Initialize the HotelController.
        /// </summary>
        public HotelController()
        {
            _hotelService = new HotelService();
        }

        /// <summary>
        /// Get a List with all Hotels present in the database.
        /// </summary>
        /// <returns>Filled, or empy Collection.</returns>
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _hotelService.GetCollection());
            }
            catch (Exception ex)
            {
                 return HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// Get a specific Hotel with their ID. (/api/hotel?ID=1)
        /// </summary>
        /// <param name="p_id">ID of the Hotel.</param>
        /// <returns>Hotelobject, or NULL.</returns>
        public HttpResponseMessage Get([FromUri(Name = "ID")] int p_id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _hotelService.GetById(p_id));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
    }
}