using System;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Models.Repository;
using Project.Models.ViewModel;
using Newtonsoft.Json;
using Project.Models.Interfaces;
namespace Project.Controllers
{
    public class PatientController : Controller
    {
        private readonly ILogger<PatientController> logger;
        private readonly IPatient pa;
        private readonly IDoctor doc;
        public PatientController(ILogger<PatientController> logger, IPatient pa,IDoctor doc)
        {
            this.logger = logger;
            this.pa = pa;
            this.doc = doc;
        }
        public ViewResult Login()
        {
            return View();
        }
       [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            if (pa.validatePass(Email, Password))

            {
                HttpContext.Session.SetString("EmailP", Email);
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.Data = "Invalid Login.";
                return View("Login");
            }
        }
        public JsonResult EmailExist(string Email)
        {
            if(pa.checkPatientExist(Email))
                return Json("Email Already Exist.");
            return Json("");
        }
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Patient patient)
        {
            if (pa.addPatient(patient))
            {
                HttpContext.Session.SetString("EmailP", patient.Email);
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.Data = "Patient Already exist.";
                return View("SignUp");
            }
        }
        public IActionResult Home()
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
            {
                var email = HttpContext.Session.GetString("EmailP");
                List<UserAppointments> app = pa.GetUserAppointments(email);
                return View(app);
            }
            else
                return RedirectToAction("Index", "HomeController");

        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
                HttpContext.Session.Remove("EmailP");
           return RedirectToAction("Index", "HomeController");
        }

        public IActionResult UserAppointment()
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
            {
                var email = HttpContext.Session.GetString("EmailP");
                List<UserAppointments> app = pa.GetUserAppointments(email);
                return View("UserAppointment",app);
            }
            else
                return RedirectToAction("Index", "HomeController");

        }
        //public JsonResult UserAppointment()
        //{
        //    Console.WriteLine($"Email: {PEmail}");
        //    List<UserAppointments> app = pa.GetUserAppointments(PEmail);
        //    Console.WriteLine(app[0].appNo);
        //    return Json(app);
        //}
        [HttpGet,HttpPost]
        public JsonResult GetAppointments()
        {
            var email = HttpContext.Session.GetString("EmailP");
            List<UserAppointments> app = pa.GetUserAppointments(email);
            Console.WriteLine(email);
            return Json(new { data = app });
        }
        [HttpPost, HttpGet]
        public IActionResult PostAppointments(int id)
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
            {
                pa.DelAppointments(id);
                var email = HttpContext.Session.GetString("EmailP");
                List<UserAppointments> app = pa.GetUserAppointments(email);
                Console.WriteLine(app[0].appNo);
                
                return View("UserAppointment", app);
            }
            else
                return RedirectToAction("Index", "HomeController");
        }

        public IActionResult DocInfo()
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
            {
                return View("DocInfo");
            }
            else
                return RedirectToAction("Index", "HomeController");
        }
        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
            {
                pa.DelAppointments(id);
                return View("UserAppointment");
            }
            else
                return RedirectToAction("Index", "HomeController");

        }
        public IActionResult MakeAppointment()
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
            {
                List<DocInfo> list = doc.getDoctors();
                return View("UserAppointment",list);
            }
            else
                return RedirectToAction("Index", "HomeController");

        }
        public IActionResult addApp(Appointment app)
        {
            if (HttpContext.Session.Keys.Contains("EmailP"))
            {
                return View();
            }
            else
                return RedirectToAction("Index", "HomeController");

        }
    }
}

