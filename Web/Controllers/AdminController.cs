using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// Handle all Admin-Requests (/api/Admin)
    /// </summary>
    /// <author>Lucas Engel</author>
    public class AdminController : BaseController
    {
        #region Dependencies
        private readonly AdminService _adminService;
        #endregion

        /// <summary>
        /// Initialize the AdminController.
        /// </summary>
        public AdminController()
        {
            _adminService = new AdminService();
        }

        /// <summary>
        /// Check if Logindata is valid. (/api/Admin?Username=xxx&Password=yyy)
        /// </summary>
        /// <param name="p_username">Username</param>
        /// <param name="p_password">Password</param>
        /// <returns>Filled Adminobject, or NULL.</returns>
        public HttpResponseMessage Get([FromUri(Name = "Username")]string p_username, [FromUri(Name = "Password")]string p_password)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _adminService.CheckLogin(p_username, p_password));
            }
            catch (Exception ex)
            {
                return HandleGeneralError(ex);
            }
        }
    }
}