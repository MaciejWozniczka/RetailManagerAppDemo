using Microsoft.AspNet.Identity;
using RetailManager.Library.DataAccess;
using RetailManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace RetailManager.Api.Controllers
{
    [Authorize]
    [RoutePrefix("api/Account")]
    public class UserController : ApiController
    {
        public List<User> GetById()
        {
            UserData data = new UserData();

            string userId = RequestContext.Principal.Identity.GetUserId();

            return data.GetUserById(userId);
        }
    }
}
