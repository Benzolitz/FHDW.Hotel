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
    /// <author>Lucas Engel</author>
    public class BaseController : ApiController
    {
        /// <summary>
        /// Handle all Exception which will return a Bad Request response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleBadRequestError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return am Unauthorized response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleUnauthorizationError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Unauthorized, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Forbidden response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleForbiddenError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Forbidden, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Not Found response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleNotFoundError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.NotFound, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Not Acceptable response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleNotAcceptableError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.NotAcceptable, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Request Timeout response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleRequestTimeoutError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.RequestTimeout, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Conflict response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleConflictError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Conflict, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Gone response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleGoneError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.Gone, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Length required response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleLengthRequiredError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.LengthRequired, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return a Precondition failed response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandlePreconditionFailedError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.PreconditionFailed, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return an Exceptio failed response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleExpectationFailedError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.ExpectationFailed, p_exception.Message);
        }

        /// <summary>
        /// Handle all Exception which will return an Internal Server Error response.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleInternalServerError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, p_exception.Message);
        }

        /// <summary>
        /// Handle all general Exception for which no response types are availble.
        /// </summary>
        /// <param name="p_exception">Exception that will be returned.</param>
        /// <returns>The exception message.</returns>
        public HttpResponseMessage HandleGeneralError(Exception p_exception)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError, p_exception.Message);
        }
    }
}