using System;
using System.Net;
using System.Net.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class GuestController : BaseController
    {
        #region Dependencies
        private GuestService GuestService { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public GuestController()
        {
            GuestService = new GuestService();
        }

        /// <summary>
        /// Get a list of all Bookings.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }
    }
}