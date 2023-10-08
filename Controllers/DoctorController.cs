using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.Repository;
using Project.Models.Interfaces;

namespace Project.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ILogger<DoctorController> logger;
        private readonly IDoctor doc;
        public DoctorController(ILogger<DoctorController> logger, IDoctor doc)
        {
            this.logger = logger;
            this.doc = doc;
        }
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {

            Doctor a = new Doctor { Email = Email, Password = Password };
            if (doc.validatePass(a))
                return RedirectToAction("DocHome");
            else
            {
                ViewBag.Data = "Invalid Login";
                return View("Login");
            }
        }
        public ViewResult DocHome()
        {
            return View();
        }
        public ViewResult SignUp()
        {
            return View();
        }
        public JsonResult EmailExist(string Email)
        {
            if (doc.checkDoctorExist(Email))
                return Json("Email Already Exist.");
            return Json("");
        }
        [HttpPost]
        public IActionResult SignUp(Doctor d)
        {
            if (doc.addDoctor(d))
                return RedirectToAction("DocHome");
            else
            {
                ViewBag.Data = "torDoc Already exist.";
                return View("SignUp");
            }
        }
    }
}
