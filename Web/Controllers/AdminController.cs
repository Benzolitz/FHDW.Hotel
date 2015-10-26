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
        private AdminService AdminService;
        #endregion

        public AdminController()
        {
            AdminService = new AdminService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_username"></param>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "Username")]string p_username)
        {
            try
            {
                var admin = AdminService.GetByUsername(p_username);
                return Request.CreateResponse(HttpStatusCode.OK, admin);
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }
    }
}