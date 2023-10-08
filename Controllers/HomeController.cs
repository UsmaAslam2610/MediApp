using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Diagnostics;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

    }
}