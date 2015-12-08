using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class BookingController : BaseController
    {
        #region Dependencies
        private readonly BookingService BookingService;
        #endregion


        /// <summary>
        /// 
        /// </summary>
        public BookingController()
        {
            BookingService = new BookingService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_bookingModel"></param>
        /// <returns></returns>
        public HttpResponseMessage Put([FromBody] CurrentBooking p_booking)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BookingService.Save(p_booking));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
    }
}