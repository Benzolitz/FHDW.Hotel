using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FHDW.Hotel.Web.Controllers
{
    public class ValuesController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new[] { "value1", "value2" });
        }
        
        public HttpResponseMessage Get([FromUri(Name = "Id")]int p_id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "value");
        }
        
        public void Post([FromBody]string p_value)
        {
        }
        
        public void Put(int p_id, [FromBody]string p_value)
        {
        }
        
        public void Delete(int p_id)
        {
        }
    }
}
