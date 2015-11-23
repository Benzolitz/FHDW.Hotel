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
        /// 
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "ID")] int p_id)
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "EMail")] string p_email, [FromUri(Name = "Password")] string p_password)
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Post([FromUri(Name = "Guest")] Guest p_guest)
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