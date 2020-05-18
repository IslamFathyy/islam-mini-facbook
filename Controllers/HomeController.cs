using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Facbook.Models;
using Microsoft.AspNetCore.Identity;

namespace Facbook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<Users> signInManager;

        public HomeController(ILogger<HomeController> logger, SignInManager<Users> signInManager)
        {
            _logger = logger;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return View();
            }
            else if(signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
            {
                return RedirectToAction("GetUsers", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Posts");

            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
