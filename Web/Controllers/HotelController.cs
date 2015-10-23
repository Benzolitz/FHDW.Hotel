using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FHDW.Hotel.Web.Controllers
{
    public class HotelController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hallo Hotel!");
        }
    }
}