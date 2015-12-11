using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// Handle all Booking-Requests (/api/Booking)
    /// </summary>
    /// <author>Lucas Engel</author>
    public class BookingController : BaseController
    {
        #region Dependencies
        private readonly BookingService _bookingService;
        #endregion

        /// <summary>
        /// Initialize the BookingController.
        /// </summary>
        public BookingController()
        {
            _bookingService = new BookingService();
        }

        /// <summary>
        /// Add a new Booking to the Database.
        /// </summary>
        /// <param name="p_booking">Bookingobject without an ID.</param>
        /// <returns>The same Bookingobject with an ID, or NULL.</returns>
        public HttpResponseMessage Post([FromBody] CurrentBooking p_booking)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _bookingService.Save(p_booking));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// Update an existing Booking in the Database. 
        /// </summary>
        /// <param name="p_booking">Bookingobject with an ID.</param>
        /// <returns>The same Bookingobject, or NULL.</returns>
        public HttpResponseMessage Put([FromBody] CurrentBooking p_booking)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _bookingService.Save(p_booking));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
    }
}