using DataTransTest.Models;

namespace DataTransTest.ViewModels
{
    public class CommentViewModel
    {
        public IEnumerable<Comment> Comments { get; set; } = Enumerable.Empty<Comment>();
        public Comment? Comment { get; set; }
    }
}
