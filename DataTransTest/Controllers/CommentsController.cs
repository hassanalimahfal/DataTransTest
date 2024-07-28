using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataTransTest.Data;
using DataTransTest.Models;
using DataTransTest.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace DataTransTest.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManger;

        public CommentsController(ApplicationDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManger = userManger;
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
            var comments = await _context.Comments.Include(p => p.Post).Include(u => u.AppUser).ToListAsync();

            var commentViewModel = new CommentViewModel
            {
                Comments = comments
            };

            ViewData["PostId"] = new SelectList(_context.Posts, "Id", "Title");
            ViewData["AppUserId"] = new SelectList(_userManger.Users, "Id", "FullName");

            return View(commentViewModel);
        }        
    }
}
