using System;
using System.Net;
using System.Net.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class RoomController : BaseController
    {
        #region Dependencies
        private RoomService RoomService { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public RoomController()
        {
            RoomService = new RoomService();
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