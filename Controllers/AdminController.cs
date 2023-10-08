using Microsoft.AspNetCore.Mvc;
using Project.Models.Repository;
using Project.Models.Interfaces;
using Project.Models;

namespace Project.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> logger;
        private readonly IAdmin ad;
        public AdminController(ILogger<AdminController> logger, IAdmin ad)
        {
            this.logger = logger;
            this.ad = ad;
        }
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            Admin a = new Admin { Email = Email, Password = Password };
            if (ad.validatePass(a))
                return RedirectToAction("AdminHome");
            else
            {
                return RedirectToAction("FailedLogin");
            }
        }
        public ViewResult FailedLogin()
        {
            ViewBag.Data = "Invalid Login";
            return View("Login");
        }
        public ViewResult FailedSignUp()
        {
            ViewBag.Data = "User Already Exist.";
            return View("SignUp");
        }
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string Email, string Password)
        {
            Admin a = new Admin { Email = Email, Password = Password };
            if (ad.addAdmin(a))
                return RedirectToAction("AdminHome");
            else
            {
                return View("FailedSignUp");
            }
        }
        public ViewResult AdminHome()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View("Login");
        }
    }
}

