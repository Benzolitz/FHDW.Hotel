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
        /// 
        /// </summary>
        /// <param name="p_username"></param>
        /// <param name="p_password"></param>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "Username")]string p_username, [FromUri(Name = "Password")]string p_password)
        {
            try
            {
                var admin = new Admin();

                if (p_username == "root" && p_password == "toor")
                    admin = new Admin { ID = 41, Username = "root", LoginGuid = Guid.NewGuid().ToString() };

                // var admin = AdminService.GetByUsername(p_username);
                return Request.CreateResponse(HttpStatusCode.OK, admin);
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }
    }
}