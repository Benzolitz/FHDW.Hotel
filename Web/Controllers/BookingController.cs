using System;
using System.Net;
using System.Net.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class BookingController : BaseController
    {
        #region Dependencies
        private BookingService BookingService { get; set; }
        #endregion

        public BookingController()
        {
            BookingService = new BookingService();
        }

        /// <summary>
        /// Get a list of all Bookings.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Booking1", "Booking2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }
    }
}