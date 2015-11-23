using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class HotelController : BaseController
    {
        #region Dependencies
        private HotelService HotelService { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public HotelController()
        {
            HotelService = new HotelService();
        }

        /// <summary>
        /// GetCollection a list of all Bookings.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, HotelService.GetCollection());
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }

        /// <summary>
        /// GetCollection a list of all Bookings.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "ID")]int p_id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Hallo Eduard");
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }
    }
}