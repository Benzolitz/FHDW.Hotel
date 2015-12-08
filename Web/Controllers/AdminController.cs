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
    public class AdminController : BaseController
    {
        #region Dependencies
        private readonly AdminService AdminService;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public AdminController()
        {
            AdminService = new AdminService();
        }

        /// <summary>
        /// Check if the given Logindata is valid and return an Adminobject.
        /// </summary>
        /// <param name="p_username">Username of the AdminModel.</param>
        /// <param name="p_password">Password of the AdminModel.</param>
        /// <returns>A valid Adminobject or NULL.</returns>
        public HttpResponseMessage Get([FromUri(Name = "Username")]string p_username, [FromUri(Name = "Password")]string p_password)
        {
            try
            {
                var admin = AdminService.CheckLogin(p_username, p_password);
                return Request.CreateResponse(HttpStatusCode.OK, admin);
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }
    }
}