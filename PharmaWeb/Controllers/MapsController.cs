using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace PharmaWeb.Controllers
{
    [AllowAnonymous]
    public class MapsController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
