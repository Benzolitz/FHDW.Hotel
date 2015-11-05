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
        private BookingService BookingService { get; set; }
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "ID")] int p_id)
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "Guest")] Guest p_guestId)
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