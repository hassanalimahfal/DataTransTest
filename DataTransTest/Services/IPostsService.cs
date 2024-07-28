using DataTransTest.Models;

namespace DataTransTest.Services
{
    public interface IPostsService
    {
        public Task<IEnumerable<Post>> GetAll();
        public Task<Post?> GetById(int? id);
        public Task<Post> Add(Post post);
        public Task Update(int id, Post post);
        public Task Remove(int id);
    }
}
