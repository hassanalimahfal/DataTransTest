using System.ComponentModel.DataAnnotations;

namespace DataTransTest.Models
{
    public class Post
    {
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(2500)]
        public string Body { get; set; } = string.Empty;        

        /*[Display(Name = "User")]
        public string AppUserId { get; set; } = string.Empty;
        public AppUser? AppUser { get; set; }*/

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
