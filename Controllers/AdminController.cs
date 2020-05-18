using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facbook.Data;
using Facbook.Models;
using Facbook.ViewModell;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Facbook.Controllers
{

    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private  RoleManager<Applicationroles> _roleManager;
        private  UserManager<Users> _usermanager;
        private readonly SignInManager<Users> _SignInManager;
        private readonly ApplicationDbContext _context;

        public AdminController(RoleManager <Applicationroles> roleManager,UserManager<Users>usermanager, SignInManager<Users> SignInManager,
                                       ApplicationDbContext context)
        {
            this._roleManager = roleManager;
            this._usermanager = usermanager;
            _SignInManager = SignInManager;
            _context = context;
        }



        [ActionName("Home")]
        public IActionResult Index()
        {

            return View("index");
        }

        [ActionName("Users")]
        public IActionResult GetUsers()
        {
            var users = _usermanager.Users.Select(u => u).Where(s => s.UserName != User.Identity.Name).ToList();
            var user = new Users();
            UsersView result = new UsersView { Users = users, User = user };
            var roles = _roleManager.Roles.ToList();
            ViewBag.roles = roles;
            return View("GetUsers", result);
        }

        [HttpPost]
        [ActionName("block")]
        public async Task<IActionResult> BlockUserAsync(string id)
        {
            var user = await _usermanager.FindByIdAsync(id);

            if (user.Isblocked == true)
                user.Isblocked = false;
            else
                user.Isblocked = true;

            var result = await _usermanager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("users", "admin");
            }
            else
            {
                ModelState.AddModelError("", "blocked failed");
            }

            return View("GetUsers");
        }

        [HttpPost]
        [ActionName("UserRole")]
        [Route("{id}")]
        public async Task<IActionResult> UserRole(string id, UsersView v)
        {
            Users user = await _usermanager.FindByIdAsync(id);


            await _usermanager.RemoveFromRoleAsync(user, user.SelectedRole);
            user.SelectedRole = v.User.SelectedRole;
            await _usermanager.AddToRoleAsync(user, v.User.SelectedRole);
            await _usermanager.UpdateAsync(user);
            var users = _usermanager.Users.Select(u => u).Where(s => s.UserName != User.Identity.Name);

            return RedirectToAction("users");
        }









        [HttpGet]
         public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(createRoleviewModel vm)
        {
            if (ModelState.IsValid)
            {
                Applicationroles Applicationrole = new Applicationroles() { Name = vm.RoleName };
              IdentityResult result=await _roleManager.CreateAsync(Applicationrole);
                if (result.Succeeded)
                    return RedirectToAction("ListRoles", "Admin");
                //to check if role already exists show error msg already taken
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(vm);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
           var roles= _roleManager.Roles;
            return View(roles);
        }
        [HttpGet]
        public async Task< IActionResult> EditRole(string id)
        {
            var role =  await _roleManager.FindByIdAsync(id);
            if(role==null)
            {
                ViewBag.ErrorMessage = $"Role Not Found";
             }
              var model = new EditRoleviewmodel() { Id = role.Id, RoleName = role.Name };
                foreach (var user in _usermanager.Users)
                {
                  if(await  _usermanager.IsInRoleAsync(user, role.Name))
                    model.UserHasRole.Add(user.UserName);

                }
             
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleviewmodel vm)
        {
            var role = await _roleManager.FindByIdAsync(vm.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role Not Found";
                return View("NOtFound");
            }
            else
            {
                role.Name = vm.RoleName;
             IdentityResult result=await _roleManager.UpdateAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("ListRoles", "Admin");
                //to check if role already exists show error msg already taken
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(vm);
            }

          
        }
        [HttpGet]
        public async Task<IActionResult> EditUserInRole(string RoleId)
        {
            ViewBag.RoleId = RoleId;

            var role = await _roleManager.FindByIdAsync(RoleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role Not Found";
                return View("NotFound");
            }
           
                var model = new List<UserRoleViewmodel>();
            
                foreach (var user in _usermanager.Users)
                {
                var vm = new UserRoleViewmodel() { UserId = user.Id, UserName = user.UserName };
                if(await _usermanager.IsInRoleAsync(user, role.Name))
                {
                    vm.IsSelected = true;
                }
                else
                {
                    vm.IsSelected = false;
                }
                model.Add(vm);
                }
           
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUserInRole(IList <UserRoleViewmodel> model ,string RoleId)
        {
            ViewBag.RoleId = RoleId;

            var role = await _roleManager.FindByIdAsync(RoleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role Not Found";
                return View("NotFound");

            }

            for (int i = 0; i < model.Count; i++)
            {
                var myuser = await _usermanager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;
                if(model[i].IsSelected  &&  ! await  (_usermanager.IsInRoleAsync(myuser, role.Name))) 
                {
                    result= await _usermanager.AddToRoleAsync(myuser,role.Name);
                }
                else if ( !model[i].IsSelected && await (_usermanager.IsInRoleAsync(myuser, role.Name)))
                {
                    result = await _usermanager.RemoveFromRoleAsync(myuser, role.Name);
                }
                else
                {
                    continue;
                }
                if (result.Succeeded)
                {
                    if (i < model.Count - 1)
                        continue;

                    else
                   
                        return RedirectToAction("EditRole", new { id = RoleId });
                
                }
               
            }
            return RedirectToAction("EditRole", new { id = RoleId });


        }
    }
}