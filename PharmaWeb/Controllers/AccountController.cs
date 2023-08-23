using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PharmaWeb.Data;
using System.Security.Claims;

namespace PharmaWeb.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddClaim(string userId, string claimType, string claimValue)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            Claim claim = new Claim(claimType, claimValue);
            var result = await _userManager.AddClaimAsync(user, claim);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Errors(result);
                return View();
            }
        }


        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
