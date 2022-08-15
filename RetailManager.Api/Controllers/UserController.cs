using Microsoft.AspNet.Identity;
using RetailManager.Library.DataAccess;
using RetailManager.Library.Models;
using System.Linq;
using System.Web.Http;

namespace RetailManager.Api.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public User GetById()
        {
            UserData data = new UserData();

            string userId = RequestContext.Principal.Identity.GetUserId();

            return data.GetUserById(userId).First();
        }
    }
}