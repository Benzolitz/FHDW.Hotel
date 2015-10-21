using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// The BaseController will be used as the super class for all controller.
    /// Redundant Methods and workloads will be handled here.
    /// </summary>
    public class BaseController : ApiController
    {
        
        /// <summary>
        /// Handle all general Exceptions.
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, p_exception.Message);
        }
    }
}