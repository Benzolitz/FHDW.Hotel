using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class WebApiApplication : HttpApplication
    {
        #region Dependencies
        public DatabaseService DatabaseService;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public WebApiApplication()
        {
            DatabaseService = new DatabaseService();
        }

        /// <summary>
        /// 
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(Register);
            DatabaseService.CreateDatabaseWithTestData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}");
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));;
        }
    }
}
