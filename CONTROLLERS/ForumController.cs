using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WebApplication99.Controllers
{
    public class ForumController : Controller
    {
        [Authorize(Roles = "admin", AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Topic()
        {
            return View();
        }
    }
}
