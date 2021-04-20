using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Cellogram.Models;

namespace Cellogram.Controllers
{
    public class HomeController : Controller
    {
        private readonly WgDataContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(WgDataContext db,ILogger<HomeController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray();

             return View(posts);
        }

       [Authorize]
       public IActionResult Post()
       {
            var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray();

             return View(posts);
       }

        [Authorize]
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        
        [Authorize]
       [HttpPost, Route("create")]
       public IActionResult Create(Post post)
       {
           if(!ModelState.IsValid)
                return View();

            post.User = User.Identity.Name;
            post.Posted = DateTime.Now;
            post.Time = DateTime.Now.ToLongTimeString();
            post.Likes = 12;
            post.ProfileImage = "https://scontent-jnb1-1.xx.fbcdn.net/v/t1.6435-1/p200x200/67740894_2353677471419768_1908112282936672256_n.jpg?_nc_cat=102&ccb=1-3&_nc_sid=7206a8&_nc_ohc=9Asn5NoHW5wAX8i63dQ&_nc_ht=scontent-jnb1-1.xx&tp=6&oh=5532842367177dbb2a681338aa693da3&oe=60A1B467";

            _db.Posts.Add(post);
            _db.SaveChanges();

            return View();
       }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
