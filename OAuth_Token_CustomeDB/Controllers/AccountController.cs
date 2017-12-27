using OAuth_Token_CustomeDB.Services;
using System.Linq;
using System.Web.Http;

namespace OAuth_Token_CustomeDB.Controllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        [HttpGet]
        [Route("api/account/getuser/{id}")]
        public IHttpActionResult GetUFirstUser(int id)
        {
            // Get user from dummy list
            var user = new UserService().GetUserList().FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }
    }
}
