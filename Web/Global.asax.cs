using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using FHDW.Hotel.BLL;

namespace FHDW.Hotel.Web
{
    /// <summary>
    /// Global configuration of the server. Only gets initialized once the server starts.
    /// </summary>
    /// <author>Lucas Engel</author>
    public class WebApiApplication : HttpApplication
    {
        /// <summary>
        /// Initilize the Application.
        /// </summary>
        public WebApiApplication()
        {
            new DatabaseService().CreateDatabaseWithTestData();
        }

        /// <summary>
        /// Call once, when the application first starts.
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(Register);
        }

        /// <summary>
        /// Set configurations for the server.
        /// </summary>
        /// <param name="p_config">Current serverconfiguration.</param>
        public static void Register(HttpConfiguration p_config)
        {
            p_config.MapHttpAttributeRoutes();
            p_config.Routes.MapHttpRoute("DefaultApi", "api/{controller}");
            p_config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));;
        }
    }
}
