using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// Handle all Guest-Requests (/api/Guest)
    /// </summary>
    /// <author>Lucas Engel</author>
    public class GuestController : BaseController
    {
        #region Dependencies
        private readonly GuestService _guestService;
        #endregion

        /// <summary>
        /// Initialize the GuestController.
        /// </summary>
        public GuestController()
        {
            _guestService = new GuestService();
        }

        /// <summary> 
        /// Check if Logindata is valid. (/api/Guest?EMail=xxx&Password=yyy)
        /// </summary>
        /// <param name="p_username">Username</param>
        /// <param name="p_password">Password</param>
        /// <returns>Filled Guestobject, or NULL.</returns>
        public HttpResponseMessage Get([FromUri(Name = "EMail")] string p_email, [FromUri(Name = "Password")] string p_password)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _guestService.CheckLogin(p_email, p_password));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// Add a new Guest to the Database.
        /// </summary>
        /// <param name="p_guest">Guestobject without an ID.</param>
        /// <returns>The same Guestobject with an ID, or NULL.</returns>
        public HttpResponseMessage Post([FromBody] Guest p_guest)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _guestService.SaveGuest(p_guest));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// Update an existing Guest in the Database. 
        /// </summary>
        /// <param name="p_guest">Guestobject with an ID.</param>
        /// <returns>The same Guestobject, or NULL.</returns>
        public HttpResponseMessage Put([FromBody] Guest p_guest)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _guestService.SaveGuest(p_guest));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
    }
}