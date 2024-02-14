using eshop.MVC.Models;
using eshop.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;

namespace eshop.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string? gidilecekUrl = null)
        {
            ViewBag.ReturnUrl = gidilecekUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login, string? gidilecekUrl = null)
        {
            if (ModelState.IsValid)
            {
                var user = userService.ValidateUser(login.UserName, login.Password);
                if (user != null)
                {
                    var claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                        new Claim(ClaimTypes.Role, user.Role),
                        new Claim(ClaimTypes.Email, user.Email),


                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);
                    if (!string.IsNullOrEmpty(gidilecekUrl) && Url.IsLocalUrl(gidilecekUrl))
                    {
                        return Redirect(gidilecekUrl);
                    }
                    return Redirect("/");
                }

                ModelState.AddModelError("login", "Kullanıcı adı ya da şifre yanlış!");
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
