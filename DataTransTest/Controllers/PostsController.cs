using Microsoft.AspNetCore.Mvc;
using DataTransTest.Models;
using DataTransTest.Services;
using Microsoft.AspNetCore.Authorization;

namespace DataTransTest.Controllers
{
  [Authorize(Roles = "Admin")]
    public class PostsController : Controller
    {
        private readonly IPostsService _postsService;

        public PostsController(IPostsService postsService)
        {
            _postsService = postsService;
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            try
            {
                var posts = await _postsService.GetAll();
                return View(posts);
            }
            catch (Exception ex)
            {
                Problem(ex.Message);
            }

            return View();
        }      

        // GET: Posts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Post post)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var posts = await _postsService.Add(post);
                }
                catch (Exception ex)
                {
                    Problem(ex.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var post = await _postsService.GetById(id);
                if (post == null)
                {
                    return NotFound();
                }
                return View(post);
            }
            catch (Exception ex)
            {
                Problem(ex.Message);
            }
            return View();
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _postsService.Update(id, post);
                }
                catch (Exception ex)
                {
                    Problem(ex.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                var post = await _postsService.GetById(id);
                if (post == null)
                {
                    return NotFound();
                }
                return View(post);
            }
            catch (Exception ex)
            {
                Problem(ex.Message);
            }
            return View();
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var post = await _postsService.GetById(id);
                if (post != null)
                {
                    await _postsService.Remove(id);
                }
            }
            catch (Exception ex)
            {
                Problem(ex.Message);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
