using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Facbook.Data;
using Facbook.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Facbook.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<Users> usermanager;
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment HostingEnvironment;

        [Obsolete]
        public ProfileController(ApplicationDbContext context, UserManager<Users> usermanager, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.usermanager = usermanager;
            this.HostingEnvironment = hostingEnvironment;
        }
        //public async Task<IActionResult> getCurrentUser()
        //{
        //    var user = await usermanager.GetUserAsync(HttpContext.User);
        //    ViewBag.IsProfileOwner = user.Id;

        //    return View("Index");
        //}
   
        [HttpGet]
 
        public async Task<IActionResult> Index()
        {
            var user = await usermanager.GetUserAsync(HttpContext.User);
            ViewBag.IsProfileOwner = user.Id;
            var userData=   await _context.Users.Include(x => x.Posts).ThenInclude(r => r.Attachment).SingleAsync(x => x.Id == user.Id);
           
            return View(userData);
        }
        [HttpGet]
        public async Task<IActionResult> getSpcificUser(string id)
        {
            var user = await usermanager.GetUserAsync(HttpContext.User);
            var userData = await _context.Users.Include(x => x.Posts).ThenInclude(r => r.Attachment).SingleAsync(x => x.Id == id);
            if (id == user.Id)
                return RedirectToAction("Index");
            return View("Index" ,userData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Index(Users user)

        {
            var userr = await usermanager.GetUserAsync(HttpContext.User);
            ViewBag.IsProfileOwner = userr.Id;
            var userData = _context.Users.Find(user.Id);
            if ( user!=null && user.Photoimg != null)
            {
                string uploadfolder = Path.Combine(HostingEnvironment.WebRootPath, "Images");
                //generate global unique id
                string uniquefilename = Guid.NewGuid().ToString() + "_" + user.Photoimg.FileName;
                string filepath = Path.Combine(uploadfolder, uniquefilename);
                user.Photoimg.CopyTo(new FileStream(filepath, FileMode.Create));
                userData.Photo = uniquefilename;
                _context.SaveChanges();
            }
            if (user != null && user.Coverimg != null)
            {
                string uploadfolder2 = Path.Combine(HostingEnvironment.WebRootPath, "Images");
                //generate global unique id
                string uniquefilename2 = Guid.NewGuid().ToString() + "_" + user.Coverimg.FileName;
                string filepath = Path.Combine(uploadfolder2, uniquefilename2);
                user.Coverimg.CopyTo(new FileStream(filepath, FileMode.Create));
                userData.Cover= uniquefilename2;
                _context.SaveChanges();
            }

            // return View(userData);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditInfo(string id)
        {
            var userData = _context.Users.Find(id);
            if (userData == null)
                return View("NotFound");

            return PartialView("_EditInfoPartial",userData);
        }
        [HttpPost]
        public IActionResult EditInfo(Users model)
        {
            var userData = _context.Users.Find(model.Id);
            userData.Bio = model.Bio;
            userData.Birthdate = model.Birthdate;
            userData.PhoneNumber = model.PhoneNumber;
            userData.Gender = model.Gender;
            _context.SaveChanges();
            //return View("Index",userData);
            ///return Index(userData.Id);
           return RedirectToAction(nameof(Index));
            //return View("_EditInfoPartial", userData);
            //return View(nameof(Index),userData);
            //return View(userData);
      
          //  return View(userData);
        }

    }
}