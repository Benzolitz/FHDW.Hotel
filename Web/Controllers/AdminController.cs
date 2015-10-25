using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_username"></param>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "Username")]string p_username)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Test");
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }
    }
}