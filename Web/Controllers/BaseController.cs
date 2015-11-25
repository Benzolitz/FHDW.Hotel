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
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleBadRequestError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleUnauthorizationError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Unauthorized, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleForbiddenError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Forbidden, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleNotFoundError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.NotFound, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleNotAcceptableError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.NotAcceptable, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandlRequestTimeoutError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.RequestTimeout, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleConflictError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Conflict, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleGoneError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Gone, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleLengthRequiredError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.LengthRequired, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandlePreconditionFailedError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.PreconditionFailed, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleExpectationFailedError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.ExpectationFailed, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleInternalServerError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, p_exception.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_exception"></param>
        /// <returns></returns>
        public HttpResponseMessage HandleGeneralError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, p_exception.Message);
        }
    }
}