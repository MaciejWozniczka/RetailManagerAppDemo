using RetailManager.DesktopUI.Library.Models;
using System.Threading.Tasks;

namespace RetailManager.DesktopUI.Library.Api
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}