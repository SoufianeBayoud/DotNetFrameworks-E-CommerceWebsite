using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using PharmaWeb.Models;
using System.Diagnostics;

namespace PharmaWeb.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHtmlLocalizer<HomeController> _localizer;


        public HomeController(ILogger<HomeController> logger, IHtmlLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["Welcome"] = _localizer["Welcome"];
            return View();
        }

        [HttpPost]
        public IActionResult setLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(

                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return LocalRedirect(returnUrl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}