using System.Web.Http;

namespace ThorAPI.Controllers
{
    [Authorize]
    public class ShipmentsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
