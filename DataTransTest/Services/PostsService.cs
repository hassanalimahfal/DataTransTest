using DataTransTest.Data;
using DataTransTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DataTransTest.Services
{
    public class PostsService : IPostsService
    {
        private readonly ApplicationDbContext _context;
        public PostsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _context.Posts.ToListAsync();
        }


        public async Task<Post?> GetById(int? id)
        {
            return await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);
        }


        public async Task<Post> Add(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }


        public async Task Update(int id, Post post)
        {
            var existingPost = await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);
            if (existingPost != null)
            {
                existingPost.Title = post.Title;
                existingPost.Body = post.Body;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Post not found.");
            }
        }


        public async Task Remove(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Post not found.");
            }
        }

    }
}
