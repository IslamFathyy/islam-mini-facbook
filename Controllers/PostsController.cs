using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Facbook.Data;
using Facbook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Facbook.ViewModell;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace Facbook.Controllers
{
 
   
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Users> usermanager;
        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public PostsController(ApplicationDbContext context, UserManager<Users> usermanager,IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.usermanager = usermanager;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            var user = await usermanager.GetUserAsync(HttpContext.User);          
            var applicationDbContext = _context.posts.Include(a => a.Attachment).Include(a => a.Likes).ToList();
            ViewBag.IsAuth = user.Id;
           
            var query = applicationDbContext.OrderByDescending(o => o.PostDate).Where(a => a.IsDeleted == false).ToList();
          
           return View(query);
        }

        public IActionResult AddLike(string userID, int postID)
        {
            Likes oldlike = _context.Likes.FirstOrDefault(i => i.UserId == userID && i.PostId == postID &&i.IsDeleted==true);
            if (oldlike != null)
            {
                oldlike.IsDeleted = false;
            }
            else
            {
                Likes obj = new Likes() { PostId = postID, UserId = userID, IsDeleted = false };
                _context.Likes.Add(obj);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");

            }
        public IActionResult Dislike(string userID, int postID)
        {
           
            Likes obj = _context.Likes.FirstOrDefault(i => i.UserId == userID && i.PostId == postID && i.IsDeleted==false);
            if (obj != null)
            {
                obj.IsDeleted = true;
                

                _context.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public int Getlikescount(int? id)
        {

            var users = _context.Likes.Where(i => i.PostId == id && i.IsDeleted == false).ToList();
            
            return users.Count ;
        }
        [HttpGet]
        [Route("Posts/listLikeUser/{id}")]
        public IActionResult listLikeUser(int? id)
        {

            var users = _context.Likes.Where(i => i.PostId == id && i.IsDeleted == false).Select(u => u.User.MyUsername).ToList();

            return PartialView("_postLikes", users);
            // return RedirectToAction("Index", users);
        }
        //public ActionResult ModalPopup(int postid)
        //{

        //        return PartialView("_postLikes");
        //}

        //public PartialViewResult _GetPartial(int postid)
        //{
        //    return PartialView("_likesList", listLikeUser(postid));
        //}





        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posts = await _context.posts
                .FirstOrDefaultAsync(m => m.PostsId == id);
       
            if (posts == null)
            {
                return NotFound();
            }

            return View(posts);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            return RedirectToAction("index","profile") ;
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create( Posts posts)
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = null;
                posts.HasAttachment = false;
                posts.IsDeleted = false;
                if (posts.photos?.Count>0)
                {
                    posts.HasAttachment = true;
                   
                    foreach (IFormFile photo in posts.photos)
                    {
                        string uploadfolder = Path.Combine(hostingEnvironment.WebRootPath,"Images");
                        //generate global unique id
                        uniquefilename = Guid.NewGuid().ToString()+"_" +photo.FileName;
                        string filepath = Path.Combine(uploadfolder,uniquefilename);
                      photo.CopyTo(new FileStream(filepath, FileMode.Create));
                        posts.Attachment.Add(new Attachment() { PostId = posts.PostsId, Url = uniquefilename });
                      
                     
                   
                    }
    
                }
                var user = await usermanager.GetUserAsync(HttpContext.User);

                posts.UserId = user.Id;
                posts.PostDate = DateTime.Now;
                
               
                _context.Add(posts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(posts);
        }

        // GET: Posts/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var posts = _context.posts.Include(c => c.Attachment);
            var post = posts.First(p => p.PostsId == id);

            if (post == null)
            {
                return NotFound();
            }
            return PartialView("_EditPostPartial", post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostsId,PostBody,PostDate,IsDeleted,HasAttachment,UserId")] Posts posts)
        {
            if (id != posts.PostsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(posts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostsExists(posts.PostsId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //return View(posts);
            return RedirectToAction(nameof(Index));
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var posts = await _context.posts
                .FirstOrDefaultAsync(m => m.PostsId == id);
            if (posts == null)
            {
                return NotFound();
            }

            return PartialView("_DeletePostPartial",posts);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var posts = await _context.posts.FindAsync(id);
            posts.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostsExists(int id)
        {
            return _context.posts.Any(e => e.PostsId == id);
        }
    }
}
